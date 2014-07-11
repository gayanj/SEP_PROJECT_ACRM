using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace SEPMetro
{

    public partial class BatteryForm : Form
    {

        PerfData cpuData = new PerfData();
        PerfData diskData = new PerfData();
        PerfData netData = new PerfData();

        double curBatAvg = 0;
        int curBatAvgCount = 0;
        double prevBatAvg = 0;
        double incBatAvg = 0;
        double drawBatAvg = 0;

        public enum ACLineStatus : byte
        {
            Battery = 0,
            AC = 1,
            Unknown = 255
        }

        [FlagsAttribute]
        public enum BatteryFlag : byte
        {
            High = 1,
            Low = 2,
            Critical = 4,
            Charging = 8,
            NoSystemBattery = 128,
            Unknown = 255
        }

        [StructLayout(LayoutKind.Sequential)]
        public class SYSTEM_POWER_STATUS
        {
            public ACLineStatus ACLineStatus;
            public BatteryFlag BatteryFlag;
            public byte BatteryLifePercent;
            public byte Reserved1;
            public Int32 BatteryLifeTime;
            public Int32 BatteryFullLifeTime;
        }
        protected SYSTEM_POWER_STATUS powerStatus;

        [DllImport("Kernel32.DLL", CharSet = CharSet.Auto, SetLastError = true)]
        private extern static bool GetSystemPowerStatus(SYSTEM_POWER_STATUS SystemPowerStatus);

        private Thread addDataRunner;
        private Random rand = new Random();
        public delegate void AddDataDelegate();
        public AddDataDelegate addDataDel;
        public delegate void DoAsync();
        private String batteryPercentage;
        System.Windows.Forms.Timer t;

        public BatteryForm()
        {
            InitializeComponent();
        }

        private void BatteryForm_Load(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().PriorityClass = ProcessPriorityClass.High;
            netData.Max = 1000000;
            powerStatus = new SYSTEM_POWER_STATUS();

            DoAsync async = new DoAsync(GetBatteryDetails);
            async.BeginInvoke(null, null);

            //define a thread to add values into chart
            ThreadStart addDataThreadStart = new ThreadStart(AddDataThreadLoop);
            addDataRunner = new Thread(addDataThreadStart);
            addDataDel += new AddDataDelegate(AddData);
            //add series into chart
            startTrending_Click(null, new EventArgs());

            t = new System.Windows.Forms.Timer { Enabled = true, Interval = 1000 };
            t.Tick += t_Tick;
            powerSource.TextChanged += new EventHandler(this.t_Tick);

            metroComboBox1.Items.Add("Monitor");
            metroComboBox1.Items.Add("Fan");
            metroComboBox1.Items.Add("Heat pipe");
            metroComboBox1.Items.Add("Refrigeration");
            metroComboBox1.Items.Add("TemperatureProbe");
            metroComboBox1.Items.Add("CDROM Drive");
            metroComboBox1.Items.Add("Disk Drive");
            metroComboBox1.Items.Add("Floppy Drive");
            metroComboBox1.Items.Add("Tape Drive");
            metroComboBox1.Items.Add("Mother Board");
            metroComboBox1.Items.Add("USB Hub");
            metroComboBox1.Items.Add("Network adapter");
            metroComboBox1.Items.Add("Voltage Probe");
            metroComboBox1.Items.Add("Printer");
            metroComboBox1.Items.Add("Processor");

            this.metroComboBox1.SelectedIndexChanged +=
            new System.EventHandler(metroComboBox1_SelectedIndexChanged);

        }



        void t_Tick(object sender, EventArgs e)
        {
            RetrievePowerStatus();
            powerSource.Text =
               (RunningOnBattery ? "Battery" : "AC");

            powerBatteryState.Text =
                    Battery.ToString();

            if (BatteryLifeLeftPercent <=
                metroProgressBar1.Maximum)
            {
                metroProgressBar1.Value = BatteryLifeLeftPercent;
            }

            batteryTimeLeft.Text = BatteryLifeTimeLeft.ToString();
            String status = ReportDiskStatus();
            diskStatus.Text = status;
        }

        public bool RetrievePowerStatus()
        {
            bool result = GetSystemPowerStatus(powerStatus);

            return result;
        }

        public bool RunningOnBattery
        {
            get
            {
                if (ACLineStatus.Battery ==
                    powerStatus.ACLineStatus)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public BatteryFlag Battery
        {
            get
            {
                return powerStatus.BatteryFlag;
            }
        }

        public byte BatteryLifeLeftPercent
        {
            get { return powerStatus.BatteryLifePercent; }
        }

        public TimeSpan BatteryLifeTimeLeft
        {
            get
            {
                TimeSpan span = new TimeSpan(0);
                if (-1 != powerStatus.BatteryLifeTime)
                {
                    span = TimeSpan.FromSeconds(powerStatus.BatteryLifeTime);
                }
                return span;
            }
        }

        public TimeSpan FullBatteryLifeTime
        {
            get
            {
                TimeSpan span = new TimeSpan(0);
                if (-1 != powerStatus.BatteryFullLifeTime)
                {
                    span = TimeSpan.FromSeconds(powerStatus.BatteryFullLifeTime);
                }
                return span;
            }
        }

        public void GetBatteryDetails()
        {
            int i = 0;
            PowerStatus ps = SystemInformation.PowerStatus;
            while (true)
            {
                if (this.InvokeRequired)
                    this.Invoke(new Action(() => batteryPercentage = ps.BatteryLifePercent.ToString() + i.ToString()));
                else
                    batteryPercentage = ps.BatteryLifePercent.ToString() + i.ToString();

                i++;
            }
        }

        private void startTrending_Click(object sender, System.EventArgs e)
        {

            //add series from min to max
            DateTime minValue = DateTime.Now;
            DateTime maxValue = minValue.AddSeconds(120);
            chart1.ChartAreas[0].AxisX.Minimum = minValue.ToOADate();
            chart1.ChartAreas[0].AxisX.Maximum = maxValue.ToOADate();
            chart1.Series.Clear();


            Series newSeries = new Series("Battery Percentage");
            newSeries.ChartType = SeriesChartType.Line;
            newSeries.BorderWidth = 2;
            newSeries.Color = Color.OrangeRed;
            newSeries.XValueType = ChartValueType.Time;
            chart1.Series.Add(newSeries);

            //start thread to add data into chart
            addDataRunner.Start();

        }

        private void AddDataThreadLoop()
        {
            try
            {
                while (true)
                {
                    chart1.Invoke(addDataDel);
                    Thread.Sleep(1000);
                }
            }
            catch (Exception ex)
            {

            }
        }

        public void AddData()
        {
            DateTime timeStamp = DateTime.Now;
            foreach (Series ptSeries in chart1.Series)
            {
                AddNewPoint(timeStamp, ptSeries);
            }
        }

        public void AddNewPoint(DateTime timeStamp, System.Windows.Forms.DataVisualization.Charting.Series ptSeries)
        {

            double newVal = 0;
            if (ptSeries.Points.Count > 0)
            {
                newVal = ptSeries.Points[ptSeries.Points.Count - 1].YValues[0] + Convert.ToDouble(batteryPercentage);
            }


            if (newVal < 0)

                newVal = 0;

            ptSeries.Points.AddXY(timeStamp.ToOADate(), Convert.ToDouble(batteryPercentage));


            double removeBefore = timeStamp.AddSeconds((double)(90) * (-1)).ToOADate();

            while (ptSeries.Points[0].XValue < removeBefore)
            {

                ptSeries.Points.RemoveAt(0);

            }


            chart1.ChartAreas[0].AxisX.Minimum = ptSeries.Points[0].XValue;

            chart1.ChartAreas[0].AxisX.Maximum = DateTime.FromOADate(ptSeries.Points[0].XValue).AddMinutes(2).ToOADate();


            chart1.Invalidate();

        }

        private void batteryInfoButton_Click(object sender, EventArgs e)
        {
            Battery b = new Battery();
            b.ShowDialog();
        }



        class PerfData
        {
            public double Current = 0;
            public double Previous = 0;
            public double Max = 100;
            public double Increment = 0;
            public double Draw = 0;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Power p = new Power();
            p.ShowDialog();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            PowerScheme p = new PowerScheme();
            p.ShowDialog();
        }

        [DllImport("Kernel32.DLL", CharSet = CharSet.Auto,
       SetLastError = true)]
        private extern static
            bool GetDevicePowerState(
                IntPtr hDevice,
                out bool fOn);
            
        protected string ReportDiskStatus()
        {
            string status = string.Empty;
            bool fOn = false;

            Assembly assembly = Assembly.GetExecutingAssembly();
            FileStream[] files = assembly.GetFiles();
            if (files.Length > 0)
            {
                IntPtr hFile = files[0].Handle;
                bool result = GetDevicePowerState(hFile, out fOn);
                if (result)
                {
                    if (fOn)
                    {
                        status = "Disk is powered up and spinning";
                    }
                    else
                    {
                        status = "Disk is sleeping";
                    }
                }
                else
                {
                    status = "Cannot get Disk Status";
                }
                Console.WriteLine(status);
            }
            return status;
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            SysPowerCap s = new SysPowerCap();
            s.ShowDialog();
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            SysPowerInfo s = new SysPowerInfo();
            s.ShowDialog();
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (metroComboBox1.SelectedIndex == 0)
                getDeviceState("Win32_DesktopMonitor");
            if (metroComboBox1.SelectedIndex == 1)
                getDeviceState("Win32_Fan");
            if (metroComboBox1.SelectedIndex == 2)
                getDeviceState("Win32_HeatPipe");
            if (metroComboBox1.SelectedIndex == 3)
                getDeviceState("Win32_Refrigeration");
            if (metroComboBox1.SelectedIndex == 4)
                getDeviceState("Win32_TemperatureProbe");
            if (metroComboBox1.SelectedIndex == 5)
                getDeviceState("Win32_CDROMDrive");
            if (metroComboBox1.SelectedIndex == 6)
                getDeviceState("Win32_DiskDrive");
            if (metroComboBox1.SelectedIndex == 7)
                getDeviceState("Win32_FloppyDrive");
            if (metroComboBox1.SelectedIndex == 8)
                getDeviceState("Win32_TapeDrive");
            if (metroComboBox1.SelectedIndex == 9)
                getDeviceState("Win32_BaseBoard");
            if (metroComboBox1.SelectedIndex == 10)
                getDeviceState("Win32_USBHub");
            if (metroComboBox1.SelectedIndex == 11)
                getDeviceState("Win32_NetworkAdapter");
            if (metroComboBox1.SelectedIndex == 12)
                getDeviceState("Win32_VoltageProbe");
            if (metroComboBox1.SelectedIndex == 13)
                getDeviceState("Win32_Printer");
            if (metroComboBox1.SelectedIndex == 14)
                getDeviceState("Win32_Processor");

        }

        private void getDeviceState(String className)
        {
            var win32DeviceClassName = className;
            var query = string.Format("select * from {0}", win32DeviceClassName);

            using (var searcher = new ManagementObjectSearcher(query))
            {
                ManagementObjectCollection objectCollection = searcher.Get();

                foreach (ManagementBaseObject managementBaseObject in objectCollection)
                {
                    foreach (PropertyData propertyData in managementBaseObject.Properties)
                    {
                        if (propertyData.Name == "Status")
                        {
                            deviceState.Text = propertyData.Value.ToString();
                            break;
                        }
                    }
                }
            }
        }

        private void powerSource_Click(object sender, EventArgs e)
        {

        }
    }

}
