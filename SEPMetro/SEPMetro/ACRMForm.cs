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
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms.DataVisualization.Charting;
using System.Diagnostics;
using RAM;
using System.Net.NetworkInformation;
using SEPMetro; //for Disk

namespace ACRM
{
    public partial class ACRMForm : Form
    {
        private ProcessLocal pl;
        private System.Windows.Forms.Timer t;
        private DataTable dt;
        private int count;
        private int value = 0;
        private int index = 0;
        private DriveInfo[] allDrives; //for disk
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
            metroButton2.Enabled = false;
            dataGridView1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            t = new System.Windows.Forms.Timer { Enabled = true, Interval = 2000 };
            t.Tick += t_Tick;
            metroButton1.Enabled = false;
            metroButton2.Enabled = true;
        }

        /// <summary>
        /// This method is used to retrieve the CPU usage of a particular process
        /// </summary>
        void t_Tick(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            //keep track of the previous scroll position
            int index = Int32.Parse(dataGridView1.FirstDisplayedScrollingRowIndex.ToString());
            pl = new ProcessLocal();
            dataGridView1.DataSource = pl.ProcessMonitor();
            if (index == -1)
            {
                dataGridView1.FirstDisplayedScrollingRowIndex = index + 1;
            }
            else
            {
                dataGridView1.FirstDisplayedScrollingRowIndex = index;
            }
            this.changeUsageValue();
            this.updateChart();
            count++;
        }

        #region Codes for Hard Disk Monitor
        //show new File System Monitor Window
        private void fileSysMonBtn_Click(object sender, EventArgs e)
        {

        }

        //Fill Volume Information
        private void driveListCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        //File the Volumes and Physical Drives Lists
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // Retrieve Disk Detail through WMI
        private void phyDiskComBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        //Show New Disk Performance Window
        private void btnDiskPerf_Click(object sender, EventArgs e)
        {
            
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            metroButton1.Enabled = true;
            metroButton2.Enabled = false;
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
            //start thread to add data into chart

            addDataRunner.Start();

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
                this.cpuChart.DataBind();
            }
            catch (NullReferenceException ex)
            {
                //Occurs on forced exit
            }
        }

        private void changeUsageValue()
        {
            value = Int32.Parse(dataGridView1[2, index].Value.ToString());
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
            this.changeUsageValue();
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void button6_Click(object sender, EventArgs e)
        {

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

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            t = new System.Windows.Forms.Timer { Enabled = true, Interval = 2000 };
            t.Tick += t_Tick;
            metroButton1.Enabled = false;
            metroButton2.Enabled = true;
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            metroButton1.Enabled = true;
            metroButton2.Enabled = false;
            t.Dispose();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            MonitorBrowser m = new MonitorBrowser();
            m.ShowDialog();
        }
    }
}

    