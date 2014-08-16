using System;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using ACRMS.DISK.DiskDataHandler;

namespace ACRMS.DISK
{
    using ACRMS.DISK.DiskMonitorBundle;

    public partial class DiskPerformance : Form
    {
        private PerfCounterHD perfCountObj;
        private Timer timer;
        private DataTable tempRecordTable;
        private Stopwatch stopwatch;
        private DiskDataValues diskDataValues;
        private int updateCount;
        private bool isIdleTimeEnabled = true;
        private bool isDiskTimeEnabled = true;
        private bool isDiskQueueEnabled = true;
        private bool isAvgTransEnabled = true;

        public DiskPerformance()
        {
            InitializeComponent();
        }

        // Initialize class variables and setup the window elements
        private void DiskPerformance_Load(object sender, EventArgs e)
        {
            stopwatch = new Stopwatch();
            tempRecordTable = new DataTable("Disk Data Records");
            diskDataValues = new DiskDataValues();

            btnStop.Enabled = false;

            this.setTableChart();
            this.fillHostList();
            this.enableButtons(false);
        }

        #region FormEvents
        //Start Monitoring
        private void btnStart_Click(object sender, EventArgs e)
        {
            perfCountObj = new PerfCounterHD(hostListComboBox.SelectedItem.ToString());
            diskDataValues.HostName = hostListComboBox.SelectedItem.ToString();
            btnStop.Enabled = true;
            btnStart.Enabled = false;

            lblTransMax.Text = "0.0";
            
            stopwatch.Start(); // ready the clock

            this.enableButtons(true);

            timer = new Timer { Enabled = true, Interval = 1000 };
            timer.Tick += t_Tick;
        }

        // Update Labels, the Graph at 1 Second Interval
        void t_Tick(object sender, EventArgs e)
        {
            lblElapsedTime.Text = stopwatch.Elapsed.ToString().Substring(0, 8);
            diskDataValues = perfCountObj.GetValues();
            this.UpdateLables();
            this.updateChart();
            updateCount++;
        }

        //Stop Monitoring Destroy all the Counters to free Resources 
        private void btnStop_Click(object sender, EventArgs e)
        {

            stopwatch.Stop();
            stopwatch.Reset();

            perfCountObj.DestroyCounters();

            btnStop.Enabled = false;
            btnStart.Enabled = true;
            this.enableButtons(false);
            
            timer.Dispose();
        }

        private void btnIdleTime_Click(object sender, EventArgs e)
        {
            if (isIdleTimeEnabled == true)
            {
                btnIdleTime.Text = "Hiden";
                btnIdleTime.BackColor = Color.Red;
                HDchart.Series["% Disk Idle Time (1)"].Enabled = false;
                isIdleTimeEnabled = false;
            }
            else
            {
                btnIdleTime.Text = "Showing";
                btnIdleTime.BackColor = Color.Green;
                HDchart.Series["% Disk Idle Time (1)"].Enabled = true;
                isIdleTimeEnabled = true;
            }
        }

        private void btnDiskTime_Click(object sender, EventArgs e)
        {
            if (isDiskTimeEnabled == true)
            {
                btnDiskTime.Text = "Hiden";
                btnDiskTime.BackColor = Color.Red;
                HDchart.Series["% Disk Time (10)"].Enabled = false;
                isDiskTimeEnabled = false;
            }
            else
            {
                btnDiskTime.Text = "Showing";
                btnDiskTime.BackColor = Color.Green;
                HDchart.Series["% Disk Time (10)"].Enabled = true;
                isDiskTimeEnabled = true;
            }
        }

        private void btnDiskQueue_Click(object sender, EventArgs e)
        {
            if (isDiskQueueEnabled == true)
            {
                btnDiskQueue.Text = "Hiden";
                btnDiskQueue.BackColor = Color.Red;
                HDchart.Series["Avg. Disk Queue (100)"].Enabled = false;
                isDiskQueueEnabled = false;
            }
            else
            {
                btnDiskQueue.Text = "Showing";
                btnDiskQueue.BackColor = Color.Green;
                HDchart.Series["Avg. Disk Queue (100)"].Enabled = true;
                isDiskQueueEnabled = true;
            }
        }

        private void btnAvgTrans_Click(object sender, EventArgs e)
        {
            if (isAvgTransEnabled == true)
            {
                btnAvgTrans.Text = "Hidden";
                btnAvgTrans.BackColor = Color.Red;
                HDchart.Series["Avg. Transfer Req (1000)"].Enabled = false;
                isAvgTransEnabled = false;
            }
            else
            {
                btnAvgTrans.Text = "Showing";
                btnAvgTrans.BackColor = Color.Green;
                HDchart.Series["Avg. Transfer Req (1000)"].Enabled = true;
                isAvgTransEnabled = true;
            }
            
        }
        #endregion FormEvents

        #region Custom Methods
        private void fillHostList()
        {
            string hostName = Dns.GetHostName();
            IPHostEntry IPhostentry = Dns.GetHostEntry(hostName);

            foreach (IPAddress ipAdd in IPhostentry.AddressList)
            {
                if (ipAdd.AddressFamily == AddressFamily.InterNetwork)
                {
                    IPHostEntry remoteAdd = Dns.GetHostEntry(ipAdd);
                    hostListComboBox.Items.Add(remoteAdd.HostName);
                }
            }

            hostListComboBox.SelectedIndex = 0;
        }

        private void enableButtons(bool status)
        {
            btnAvgTrans.Enabled = status;
            btnDiskQueue.Enabled = status;
            btnDiskTime.Enabled = status;
            btnIdleTime.Enabled = status;
        }

        //Initialize the chart settings and the DataTable
        private void setTableChart()
        {
            tempRecordTable.Columns.Add("Count", typeof(int));
            tempRecordTable.Columns.Add("Idle Time", typeof(float));
            tempRecordTable.Columns.Add("Disk Time", typeof(float));
            tempRecordTable.Columns.Add("Avg Disk Queue", typeof(float));
            tempRecordTable.Columns.Add("Avg Transfer Req", typeof(float));

            HDchart.Series.Add("% Disk Idle Time (1)");
            HDchart.Series["% Disk Idle Time (1)"].ChartType = SeriesChartType.Line;
            HDchart.Series["% Disk Idle Time (1)"].XValueMember = "Count";
            HDchart.Series["% Disk Idle Time (1)"].YValueMembers = "Idle Time";

            HDchart.Series.Add("% Disk Time (10)");
            HDchart.Series["% Disk Time (10)"].ChartType = SeriesChartType.Line;
            HDchart.Series["% Disk Time (10)"].XValueMember = "Count";
            HDchart.Series["% Disk Time (10)"].YValueMembers = "Disk Time";

            HDchart.Series.Add("Avg. Disk Queue (10)");
            HDchart.Series["Avg. Disk Queue (10)"].ChartType = SeriesChartType.Line;
            HDchart.Series["Avg. Disk Queue (10)"].XValueMember = "Count";
            HDchart.Series["Avg. Disk Queue (10)"].YValueMembers = "Avg Disk Queue";

            HDchart.Series.Add("Avg. Transfer Req (100)");
            HDchart.Series["Avg. Transfer Req (100)"].ChartType = SeriesChartType.Line;
            HDchart.Series["Avg. Transfer Req (100)"].XValueMember = "Count";
            HDchart.Series["Avg. Transfer Req (100)"].YValueMembers = "Avg Transfer Req";

            HDchart.ChartAreas[0].AxisY.Maximum = 100;
            HDchart.ChartAreas[0].AxisX.Minimum = 0;
            HDchart.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Seconds;
            HDchart.ChartAreas[0].CursorX.IsUserEnabled = true;
            HDchart.ChartAreas[0].CursorX.AutoScroll = true;

            HDchart.DataSource = tempRecordTable;
            HDchart.DataBind();
        }

        //Update the DataTable with new Data and Rebind to the chart
        private void updateChart()
        {
            tempRecordTable.Rows.Add(
                updateCount,
                float.Parse(lblIdleTime.Text),
                float.Parse(lblDiskTime.Text),
                float.Parse(lblAvgDiskQ.Text),
                float.Parse(lblAvgTrans.Text));

            try
            {
                HDchart.DataBind();
            }
            catch (NullReferenceException ex)
            {
                //Occurs on forced exit
            }
        }

        private void UpdateLables()
        {
            lblDiskReads.Text = Math.Round(diskDataValues.DiskReads, 2, MidpointRounding.AwayFromZero).ToString();
            lblDiskWrites.Text = Math.Round(diskDataValues.DiskWrites, 2, MidpointRounding.AwayFromZero).ToString();
            lblDiskTrans.Text = Math.Round(diskDataValues.DiskTransfers, 2, MidpointRounding.AwayFromZero).ToString();

            lblDiskReadsBytes.Text =
                ExtraDiskMeth.SizeSuffix(
                    Math.Round(diskDataValues.DiskReadsB, 2, MidpointRounding.AwayFromZero).ToString());
            lblDiskWriteBytes.Text =
                ExtraDiskMeth.SizeSuffix(
                    Math.Round(diskDataValues.DiskWritesB, 2, MidpointRounding.AwayFromZero).ToString());
            lblDiskTransByte.Text =
                ExtraDiskMeth.SizeSuffix(
                    Math.Round(diskDataValues.DiskTransB, 2, MidpointRounding.AwayFromZero).ToString());

            lblAvgRead.Text = Math.Round(diskDataValues.AvgDiskRead, 2, MidpointRounding.AwayFromZero).ToString();
            lblAvgWrite.Text = Math.Round(diskDataValues.AvgDiskWrite, 2, MidpointRounding.AwayFromZero).ToString();
            lblAvgTrans.Text = Math.Round(diskDataValues.AvgDiskTrans, 2, MidpointRounding.AwayFromZero).ToString();

            lblAvgReadB.Text =
                ExtraDiskMeth.SizeSuffix(
                    Math.Round(diskDataValues.AvgDiskReadB, 2, MidpointRounding.AwayFromZero).ToString());
            lblAvgWriteB.Text =
                ExtraDiskMeth.SizeSuffix(
                    Math.Round(diskDataValues.AvgDiskWriteB, 2, MidpointRounding.AwayFromZero).ToString());
            lblAvgTransB.Text =
                ExtraDiskMeth.SizeSuffix(
                    Math.Round(diskDataValues.AvgDiskTransB, 2, MidpointRounding.AwayFromZero).ToString());

            lblCurrQLen.Text = Math.Round(diskDataValues.CurrQueueLen, 2, MidpointRounding.AwayFromZero).ToString();
            lblAvgReadQ.Text = Math.Round(diskDataValues.AvgDiskReadQueue, 2, MidpointRounding.AwayFromZero).ToString();
            lblAvgWriteQ.Text = Math.Round(diskDataValues.AvgDiskWriteQueue, 2, MidpointRounding.AwayFromZero).ToString();
            lblAvgDiskQ.Text = Math.Round(diskDataValues.AvgDiskQueue, 2, MidpointRounding.AwayFromZero).ToString();

            lblIOSplit.Text = Math.Round(diskDataValues.DiskIoSplit, 2, MidpointRounding.AwayFromZero).ToString();
            lblDiskTime.Text = Math.Round(diskDataValues.DiskTime, 2, MidpointRounding.AwayFromZero).ToString();
            lblIdleTime.Text = Math.Round(diskDataValues.DiskIdleTime, 2, MidpointRounding.AwayFromZero).ToString();
            lblReadTime.Text = Math.Round(diskDataValues.DiskReadTime, 2, MidpointRounding.AwayFromZero).ToString();
            lblWriteTime.Text = Math.Round(diskDataValues.DiskWriteTime, 2, MidpointRounding.AwayFromZero).ToString();
        }
        #endregion Custom Methods
    }
}
