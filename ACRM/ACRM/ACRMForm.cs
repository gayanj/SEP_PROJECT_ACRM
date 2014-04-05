using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Management;
using ACRM.CPU;
using System.Collections;
using ACRM.HDisk; //for Disk
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms.DataVisualization.Charting;
using System.Diagnostics;
using RAM;
using System.Net.NetworkInformation; //for Disk

namespace ACRM
{
    public partial class ACRMForm : Form
    {
        private ProcessLocal pl;
        private System.Threading.Timer t;
        private DataTable dt;
        private int count;
        private int value = 0;
        private int index = 0;
        private DriveInfo[] allDrives; //for disk
        private WMIDisk wd;
        private ArrayList diskModelList;
        wmiMemory wmi = new wmiMemory();
        private Thread addDataRunner;
        private Random rand = new Random();
        public delegate void AddDataDelegate();
        public AddDataDelegate addDataDel;

        delegate void SetTextCallback(string text);
        private NetworkInterface[] nics = null;
        private Boolean monitoring = false;
        private Thread wrkerthread = null;
        public ACRMForm()
        {
            InitializeComponent();
            button1.Enabled = false;
            dataGridView1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            t = new System.Threading.Timer(new TimerCallback(getProcessInfo), null, 0, 1000);
            button2.Enabled = false;
            button1.Enabled = true;
        }

        /// <summary>
        /// This method is used to retrieve the CPU usage of a particular process
        /// </summary>
        private void getProcessInfo(object sender)
        {
            dataGridView1.SafeInvoke(d => d.Visible = true);
            //keep track of the previous scroll position
            int index = Int32.Parse(dataGridView1.FirstDisplayedScrollingRowIndex.ToString());
            pl = new ProcessLocal();
            DataTable processMonitor = new DataTable();
            processMonitor.BeginLoadData();
            processMonitor = pl.ProcessMonitor();
            processMonitor.EndLoadData();
            dataGridView1.SafeInvoke(d => d.DataSource = processMonitor);
            if (index == -1)
            {
                dataGridView1.SafeInvoke(d => d.FirstDisplayedScrollingRowIndex = index + 1);
            }
            else
            {
                dataGridView1.SafeInvoke(d => d.FirstDisplayedScrollingRowIndex = index);
            }
            updateChart();
            count++;
        }

        #region Codes for Hard Disk Monitor
        //show new File System Monitor Window
        private void fileSysMonBtn_Click(object sender, EventArgs e)
        {
            FileSysMonForm fsForm1 = new FileSysMonForm();
            fsForm1.Show();
            fsForm1.Focus();
        }

        //Fill Volume Information
        private void driveListCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selInd = driveListCombo.SelectedIndex;

            dNameLbl.Text = allDrives[selInd].Name.ToString();
            dTypeLbl.Text = allDrives[selInd].DriveType.ToString();
            try
            {
                volLbl.Text = allDrives[selInd].VolumeLabel.ToString();
                dFormatLbl.Text = allDrives[selInd].DriveFormat.ToString();
                totSizeLbl.Text = ExtraDiskMeth.SizeSuffix(allDrives[selInd].TotalSize);
                totFreeLbl.Text = ExtraDiskMeth.SizeSuffix(allDrives[selInd].TotalFreeSpace);
                totAvaLbl.Text = ExtraDiskMeth.SizeSuffix(allDrives[selInd].AvailableFreeSpace);
            }
            catch (IOException ex)
            {
                volLbl.Text = "Volume Not Ready";
                dFormatLbl.Text = "Volume Not Ready";
                totAvaLbl.Text = "Volume Not Ready";
                totFreeLbl.Text = "Volume Not Ready";
                totSizeLbl.Text = "Volume Not Ready";
            }
            if (allDrives[selInd].IsReady == true)
            {
                dStatLbl.Text = "On-Line";
                dStatLbl.BackColor = Color.Green;
            }
            else
            {
                dStatLbl.Text = "Off-Line";
                dStatLbl.BackColor = Color.Red;
            }
        }

        //File the Volumes and Physical Drives Lists
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            allDrives = DriveInfo.GetDrives();
            foreach (DriveInfo d in allDrives)
            {
                driveListCombo.Items.Add(d.Name);
            }
            driveListCombo.SelectedIndex = 0;

            wd = new WMIDisk();
            diskModelList = wd.DiskInf(wd.ms);
            foreach (var v in diskModelList)
            {
                phyDiskComBox.DataSource = diskModelList;
            }
        }

        // Retrieve Disk Detail through WMI
        private void phyDiskComBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ManagementObjectSearcher mos1 = wd.phyDiskInf(phyDiskComBox.SelectedItem.ToString());
            ManagementObjectCollection moc = mos1.Get();

            foreach (ManagementObject mo in moc)
            {

                lblSerial.Text = mo["SerialNumber"].ToString().Trim();
                lblModel.Text = mo["Model"].ToString().Trim();
                lblInterface.Text = mo["InterfaceType"].ToString();
                lblCapacity.Text = ExtraDiskMeth.SizeSuffix(mo["Size"].ToString());
                lblPartitions.Text = mo["Partitions"].ToString();
                lblSig.Text = mo["Signature"].ToString();
                if (mo["FirmwareRevision"] == null)
                {
                    lblFirmware.Text = "-";
                }
                else
                {
                    lblFirmware.Text = mo["FirmwareRevision"].ToString();
                }
                lblCylinder.Text = mo["TotalCylinders"].ToString();
                lblSectors.Text = mo["TotalSectors"].ToString();
                lblHeads.Text = mo["TotalHeads"].ToString();
                lblTracks.Text = mo["TotalTracks"].ToString();
                lblBperSec.Text = mo["BytesPerSector"].ToString();
                lblSecPerTrack.Text = mo["SectorsPerTrack"].ToString();
                lblTrackPerCyl.Text = mo["TracksPerCylinder"].ToString();
            }
        }

        //Show New Disk Performance Window
        private void btnDiskPerf_Click(object sender, EventArgs e)
        {
            DiskPerformance dp = new DiskPerformance();
            dp.Show();
            dp.Focus();
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            button2.Enabled = true;
            button1.Enabled = false;
            t.Dispose();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            // Confirm user wants to close
            switch (MessageBox.Show(this, "Are you sure you want to close?", "Closing", MessageBoxButtons.YesNo))
            {
                case DialogResult.No:
                    e.Cancel = true;
                    break;
                default:
                    break;
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            int rows = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {            //Here 2 cell is target value and 1 cell is Volume
                if (Convert.ToInt32(row.Cells[2].Value) > 90)// Or your condition 
                {
                    dataGridView1.Rows[rows++].Cells[2].Style.ForeColor = Color.Red;
                }
                else
                {
                    dataGridView1.Rows[rows++].Cells[2].Style.ForeColor = Color.Green;
                }
            }
        }

        private void ACRMForm_Load(object sender, EventArgs e)
        {
            dt = new DataTable("CPU Usage");

            this.setTableChart();
            MEMORYSTATUSEX m = new MEMORYSTATUSEX();
            label31.Text = wmi.info[5];
            label32.Text = wmi.info[4];
            label33.Text = wmi.info[6];
            label34.Text = wmi.info[7] + " MHz";
            label35.Text = wmi.info[8];
            label36.Text = wmi.info[2] + " Bytes";

            ThreadStart addDataThreadStart = new ThreadStart(AddDataThreadLoop);

            addDataRunner = new Thread(addDataThreadStart);

            addDataDel += new AddDataDelegate(AddData);


            //add series into chart
            startTrending_Click(null, new EventArgs());
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

        private void AddDataThreadLoop()
        {

            while (true)
            {

                chart1.Invoke(addDataDel);


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


        private void setTableChart()
        {
            dt.Columns.Add("Seconds", typeof(int));
            dt.Columns.Add("Value", typeof(float));

            cpuChart.Series.Add("CPU Usage");
            cpuChart.Series["CPU Usage"].ChartType = SeriesChartType.Line;
            cpuChart.Series["CPU Usage"].XValueMember = "Seconds";

            cpuChart.Series["CPU Usage"].YValueMembers = "Value";
            cpuChart.ChartAreas[0].AxisY.Maximum = 100;
            cpuChart.ChartAreas[0].AxisX.Minimum = 0;
            cpuChart.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Seconds;
            cpuChart.ChartAreas[0].CursorX.IsUserEnabled = true;
            cpuChart.ChartAreas[0].CursorX.AutoScroll = true;
            cpuChart.DataSource = dt;
            cpuChart.DataBind();
        }

        private void updateChart()
        {
            dt.Rows.Add(count, value);
            try
            {
                value = Int32.Parse(dataGridView1[2, index].Value.ToString());
                this.cpuChart.SafeInvoke(e => e.DataBind());
            }
            catch (NullReferenceException ex)
            {
                //Occurs on forced exit
            }
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            foreach (var series in cpuChart.Series)
            {
                series.Points.Clear();
            }
            dt.Clear();
            count = 0;
            index = dataGridView1.CurrentCell.RowIndex;
            processName.Visible = true;
            processNameValue.Visible = true;
            processNameValue.Text = dataGridView1[1, index].Value.ToString();
            updateChart();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int count = 0;
            listBox1.Items.Clear();
            if (nics == null)
            {
                nics = NetworkInterface.GetAllNetworkInterfaces();
            }
            foreach (NetworkInterface adapter in nics)
            {
                if ((adapter.GetIPv4Statistics().BytesReceived > 0) && (!adapter.Description.Contains("Teredo")))
                {
                    count++;
                    this.SetText(adapter.Description);
                    this.SetText(String.Empty.PadLeft(adapter.Description.Length, '='));
                }
            }
            label39.Text = "Total No of network Interfaces found : " + count;
            listBox1.Visible = true;
        }

        private void ThreadProcSafe()
        {
            while (monitoring)
            {
                this.SetText("clear");
                nics = NetworkInterface.GetAllNetworkInterfaces();
                foreach (NetworkInterface adapter in nics)
                {
                    if ((adapter.GetIPv4Statistics().BytesReceived > 0) && (!adapter.Description.Contains("Teredo")))
                    {

                        this.SetText(adapter.Description);
                        this.SetText(String.Empty.PadLeft(adapter.Description.Length, '='));
                        this.SetText("Interface type ................................ : " + adapter.NetworkInterfaceType);
                        this.SetText("Physical Address .......................... : " + adapter.GetPhysicalAddress());
                        this.SetText("Operational status ....................... : " + adapter.OperationalStatus);
                        string versions = "";
                        if (adapter.Supports(NetworkInterfaceComponent.IPv4))
                        {
                            versions = "IPv4   ";
                        }
                        if (adapter.Supports(NetworkInterfaceComponent.IPv6))
                        {
                            versions += "IPv6";
                        }
                        this.SetText("IP version ...................................... : " + versions);
                        this.SetText("    Bytes Sent: " + adapter.GetIPv4Statistics().BytesSent);
                        this.SetText("    Bytes Received: " + adapter.GetIPv4Statistics().BytesReceived);
                        IPInterfaceProperties properties = adapter.GetIPProperties();
                        this.SetText("DNS enabled .......................................... : " + properties.IsDnsEnabled);
                        this.SetText("Dynamically configured DNS ................... : " + properties.IsDynamicDnsEnabled);
                        this.SetText("Receive Only .......................................... : " + adapter.IsReceiveOnly);
                        this.SetText("Multicast ................................................. : " + adapter.SupportsMulticast);
                    }
                }

                Thread.Sleep(1000);

            }
        }

        private void SetText(string information)
        {
            if (listBox1.InvokeRequired)
            {

                SetTextCallback d = new SetTextCallback(SetText);
                try
                {
                    this.Invoke(d, new object[] { information });

                }
                catch (ObjectDisposedException e)
                {

                }
            }
            else
            {
                if (information.Equals("clear"))
                {
                    listBox1.Items.Clear();
                }
                else
                {
                    listBox1.Items.Add(information);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (nics != null)
            {
                monitoring = true;

                wrkerthread = new Thread(new ThreadStart(this.ThreadProcSafe));
                wrkerthread.Start();
            }
        }

        private void button4_Click(object sender, System.EventArgs e)
        {
            monitoring = false;
        }

        private void btnDirExplorer_Click(object sender, EventArgs e)
        {
            DirSizeExplorer dse = new DirSizeExplorer();
            dse.Show();
            dse.Focus();
        }
    }
}

