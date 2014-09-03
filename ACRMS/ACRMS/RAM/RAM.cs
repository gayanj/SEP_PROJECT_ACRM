using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using ACRM.RAM;
using Microsoft.Win32.SafeHandles;
using NotificationWindow;
using RAM;
using RAM.MemoryScanner;
using ACRMS;

namespace SEPMetro
{
    public partial class RAM : Form
    {

        private System.Threading.Timer t;
        private DataTable dt;
        private int count;
        private int value = 0;
        private int index = 0;
        private DriveInfo[] allDrives; //for disk
  //      private WMIDisk wd;
        private ArrayList diskModelList;
        wmiMemory wmi = new wmiMemory();
        private Thread addDataRunner;
        private Random rand = new Random();
        public delegate void AddDataDelegate();
        public AddDataDelegate addDataDel;
        System.Windows.Forms.Timer tick1;
        System.Windows.Forms.Timer tick2;

        delegate void SetTextCallback(string text);
 //       private NetworkInterface[] nics = null;
        private Boolean monitoring = false;
        private Thread wrkerthread = null;

        PopupNotifier popupNotifier1;
        MEMORYSTATUSEX m;

        [DllImport("kernel32.dll",
           EntryPoint = "GetStdHandle",
           SetLastError = true,
           CharSet = CharSet.Auto,
           CallingConvention = CallingConvention.StdCall)]
        private static extern IntPtr GetStdHandle(int nStdHandle);
        [DllImport("kernel32.dll",
            EntryPoint = "AllocConsole",
            SetLastError = true,
            CharSet = CharSet.Auto,
            CallingConvention = CallingConvention.StdCall)]
        private static extern int AllocConsole();
        private const int STD_OUTPUT_HANDLE = -11;
        private const int MY_CODE_PAGE = 437;
        [DllImport("kernel32.dll")]
        private static extern int FreeConsole();

        public RAM()
        {
            InitializeComponent();
            ACRM_MetroMain.load.Close();
        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ram_Processes_Click(object sender, EventArgs e)
        {
            Console.WriteLine("This text you can see in debug output window.");
            //AllocConsole();
            IntPtr stdHandle = GetStdHandle(STD_OUTPUT_HANDLE);
            SafeFileHandle safeFileHandle = new SafeFileHandle(stdHandle, true);
            FileStream fileStream = new FileStream(safeFileHandle, FileAccess.Write);
            Encoding encoding = System.Text.Encoding.GetEncoding(MY_CODE_PAGE);
            StreamWriter standardOutput = new StreamWriter(fileStream, encoding);
            standardOutput.AutoFlush = true;
            Console.SetOut(standardOutput);
            Native.GetProcessList();
            Console.ReadLine();
            Console.Clear();
        }

        private void ram_Threads_Click(object sender, EventArgs e)
        {
            Console.WriteLine("This text you can see in debug output window.");

            //AllocConsole();
            IntPtr stdHandle = GetStdHandle(STD_OUTPUT_HANDLE);
            SafeFileHandle safeFileHandle = new SafeFileHandle(stdHandle, true);
            FileStream fileStream = new FileStream(safeFileHandle, FileAccess.Write);
            Encoding encoding = System.Text.Encoding.GetEncoding(MY_CODE_PAGE);
            StreamWriter standardOutput = new StreamWriter(fileStream, encoding);
            standardOutput.AutoFlush = true;
            Console.SetOut(standardOutput);
            Native.ListProcessThreads((uint)Process.GetCurrentProcess().Id);
            Console.ReadLine();
            Console.Clear();
        }

        private void ram_Heap_Click(object sender, EventArgs e)
        {
            Console.WriteLine("This text you can see in debug output window.");

            ///AllocConsole();
            IntPtr stdHandle = GetStdHandle(STD_OUTPUT_HANDLE);
            SafeFileHandle safeFileHandle = new SafeFileHandle(stdHandle, true);
            FileStream fileStream = new FileStream(safeFileHandle, FileAccess.Write);
            Encoding encoding = System.Text.Encoding.GetEncoding(MY_CODE_PAGE);
            StreamWriter standardOutput = new StreamWriter(fileStream, encoding);
            standardOutput.AutoFlush = true;
            Console.SetOut(standardOutput);
            Native.ListHeap((uint)Process.GetCurrentProcess().Id);
            Console.ReadLine();
            Console.Clear();
        }

        private void RAM_Load(object sender, EventArgs e)
        {
            AllocConsole();
            
            m = new MEMORYSTATUSEX();
            ram_DataWidth.Text = wmi.info[5];
            ram_Manufacturer.Text = wmi.info[4];
            ram_SerialNumber.Text = wmi.info[6];
            ram_Speed.Text = wmi.info[7] + " MHz";
            ram_Interleave.Text = wmi.info[8];
            ram_Capacity.Text = wmi.info[2] + " Bytes";

            ThreadStart addDataThreadStart = new ThreadStart(AddDataThreadLoop);

            addDataRunner = new Thread(addDataThreadStart);

            addDataDel += new AddDataDelegate(AddData);


            //add series into chart
            startTrending_Click(null, new EventArgs());

            //button1.Enabled = true;

            tick1 = new System.Windows.Forms.Timer { Enabled = true, Interval = Configuration.timeInterval };
            tick1.Tick += tick_Tick;
            tick2 = new System.Windows.Forms.Timer { Enabled = true, Interval = Configuration.timeInterval + 2000 };
            tick2.Tick += tick_Tick2;
        }

        void tick_Tick(object sender, EventArgs e)
        {

            m.setValues();
            popupNotifier1 = new PopupNotifier();
            popupNotifier1.TitleText = "Automated Computer Resource Management System";
            if (m.dwMemoryLoad > Configuration.percentage)
            {
                tick1.Interval = Configuration.timeInterval;
                popupNotifier1.ContentText = "Your RAM percentage is " + m.dwMemoryLoad.ToString() + "%" + Environment.NewLine;
                popupNotifier1.Delay = 2000;
                popupNotifier1.Delay = 3000;
                popupNotifier1.Image = ACRMS.Properties.Resources.a; 
                popupNotifier1.Popup();
            }

        }

        void tick_Tick2(object sender, EventArgs e)
        {
            if (Configuration.checkbox)
            {
                ProcessList.ListAllApplications();
                PopupNotifier popupNotifier2 = new PopupNotifier();
                popupNotifier2.TitleText = "Automated Computer Resource Management System";
                popupNotifier2.Delay = 2000;
                popupNotifier2.ContentText = "Most memory consuming app " + ProcessList.maxMemoryApp + " with memory of " + ProcessList.maxMemory;
                popupNotifier2.Image = ACRMS.Properties.Resources.a;
                popupNotifier2.Popup();
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


            Series newSeries = new Series("Physical Memory usage");

            newSeries.ChartType = SeriesChartType.Line;

            newSeries.BorderWidth = 2;

            newSeries.Color = Color.OrangeRed;

            newSeries.XValueType = ChartValueType.Time;

            chart1.Series.Add(newSeries);



            //start thread to add data into chart

            addDataRunner.Start();

        }

        protected override void Dispose(bool disposing)
        {

            if ((addDataRunner.ThreadState & System.Threading.ThreadState.Suspended) == System.Threading.ThreadState.Suspended)
            {

                addDataRunner.Resume();

            }

            addDataRunner.Abort();


            if (disposing)
            {

                if (components != null)
                {

                    components.Dispose();

                }

            }

            base.Dispose(disposing);

        }

        private void AddDataThreadLoop()
        {

            while (true)
            {
                try
                {
                    chart1.Invoke(addDataDel);
                }
                catch (Exception e)
                {
                }


                Thread.Sleep(1000);

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
            MEMORYSTATUSEX statusEx = new MEMORYSTATUSEX();
            statusEx.setValues();
            double newVal = 0;
            //double newVal = Convert.ToDouble(MEMORYSTATUSEX.graphMemory);
            //Console.WriteLine(statusEx.dwMemoryLoad.ToString());
            //chart1.Series["Series1"].Points.AddXY(timeStamp, newVal);
            if (ptSeries.Points.Count > 0)
            {

                newVal = ptSeries.Points[ptSeries.Points.Count - 1].YValues[0] + Convert.ToDouble(MEMORYSTATUSEX.graphMemory);

            }


            if (newVal < 0)

                newVal = 0;

            ptSeries.Points.AddXY(timeStamp.ToOADate(), Convert.ToDouble(MEMORYSTATUSEX.graphMemory));


            double removeBefore = timeStamp.AddSeconds((double)(90) * (-1)).ToOADate();

            while (ptSeries.Points[0].XValue < removeBefore)
            {

                ptSeries.Points.RemoveAt(0);

            }


            chart1.ChartAreas[0].AxisX.Minimum = ptSeries.Points[0].XValue;

            chart1.ChartAreas[0].AxisX.Maximum = DateTime.FromOADate(ptSeries.Points[0].XValue).AddMinutes(2).ToOADate();


            chart1.Invalidate();


        }

        private void ram_Configuration_Click(object sender, EventArgs e)
        {
            Configuration c = new Configuration();
            c.ShowDialog();
        }

        private void ram_IdleChecker_Click(object sender, EventArgs e)
        {
            IdleCheckForm i = new IdleCheckForm();
            i.ShowDialog();
        }

        private void ram_LiveInfo_Click(object sender, EventArgs e)
        {
            MemoryCounters m = new MemoryCounters();
            m.ShowDialog();
        }

        private void ram_MemoryInfo_Click(object sender, EventArgs e)
        {
            SystemMemoryInfo m = new SystemMemoryInfo();
            m.ShowDialog();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Browser b = new Browser();
            b.ShowDialog();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            MemoryScanner m = new MemoryScanner();
            m.MainMethod();
        }


    }
}
