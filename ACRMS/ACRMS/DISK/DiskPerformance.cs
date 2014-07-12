using ACRMS.DISK.IntelliMon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ACRMS.DISK
{
    public partial class DiskPerformance : Form
    {
        PerfCounterHD perfCountObj;
        Timer timer;
        DataTable recordTable;
        Stopwatch stopW;
        int updateCount;
        bool isIdleTimeEnabled = true;
        bool isDiskTimeEnabled = true;
        bool isDiskQueueEnabled = true;
        bool isAvgTransEnabled = true;

        public DiskPerformance()
        {
            InitializeComponent();
        }

        //Initialize the window, DataTable to Store MonitorData and the Chart
        private void DiskPerformance_Load(object sender, EventArgs e)
        {
            stopW = new Stopwatch();
            recordTable = new DataTable("Disk Data Records");

            btnStop.Enabled = false;

            this.setTableChart();
            this.fillHostList();
            this.disableButtons(false);
        }

        private void disableButtons(bool status)
        {
            btnAvgTrans.Enabled = status;
            btnDiskQueue.Enabled = status;
            btnDiskTime.Enabled = status;
            btnIdleTime.Enabled = status;
        }

        //Start Monitoring
        private void btnStart_Click(object sender, EventArgs e)
        {
            perfCountObj = new PerfCounterHD(hostListComboBox.SelectedItem.ToString());

            btnStop.Enabled = true;
            btnStart.Enabled = false;

            lblTransMax.Text = "0.0";
            
            stopW.Start(); //ready the clock

            this.disableButtons(true);

            timer = new Timer { Enabled = true, Interval = 1000 };
            timer.Tick += t_Tick;
        }

        //Update Labels, the Graph at 1 Second Interval
        void t_Tick(object sender, EventArgs e)
        {
            lblElapsedTime.Text = stopW.Elapsed.ToString().Substring(0, 8);

            lblDiskReads.Text = perfCountObj.DiskReads.ToString();
            lblDiskWrites.Text = perfCountObj.DiskWrites.ToString();
            lblDiskTrans.Text = perfCountObj.DiskTransfers.ToString();

            lblDiskReadsBytes.Text = ExtraDiskMeth.SizeSuffix(perfCountObj.DiskReadsB.ToString());
            lblDiskWriteBytes.Text = ExtraDiskMeth.SizeSuffix(perfCountObj.AvgDiskWriteB.ToString());
            lblDiskTransByte.Text = ExtraDiskMeth.SizeSuffix(perfCountObj.DiskTransB.ToString());

            lblAvgRead.Text = perfCountObj.AvgDiskRead.ToString();
            lblAvgWrite.Text = perfCountObj.AvgDiskWrite.ToString();
            lblDiskReads.Text = perfCountObj.AvgDiskTrans.ToString();

            lblAvgReadB.Text = ExtraDiskMeth.SizeSuffix(perfCountObj.AvgDiskReadB.ToString());
            lblAvgWriteB.Text = ExtraDiskMeth.SizeSuffix(perfCountObj.AvgDiskWriteB.ToString());
            lblAvgTransB.Text = ExtraDiskMeth.SizeSuffix(perfCountObj.AvgDiskTransB.ToString());

            lblCurrQLen.Text = perfCountObj.CurrQueueLen.ToString();
            lblAvgReadQ.Text = perfCountObj.AvgDiskReadQueue.ToString();
            lblAvgWriteQ.Text = perfCountObj.AvgDiskWriteQueue.ToString();
            lblAvgDiskQ.Text = perfCountObj.AvgDiskQueue.ToString();

            lblIOSplit.Text = perfCountObj.DiskIOSplit.ToString();
            lblDiskTime.Text = perfCountObj.DiskTime.ToString();
            lblIdleTime.Text = perfCountObj.DiskIdleTime.ToString();
            lblReadTime.Text = perfCountObj.DiskReadTime.ToString();
            lblWriteTime.Text = perfCountObj.DiskWriteTime.ToString();

            try
            {
                if (float.Parse(lblTransMax.Text) < float.Parse(lblDiskTrans.Text))
                {
                    lblTransMax.Text = lblDiskTrans.Text;
                    lblTransMax.BackColor = Color.Red;
                }
                if (float.Parse(lblIdleTime.Text) > 30.00f)
                {
                    lblIdleTime.BackColor = Color.Red;
                }
            }
            catch (FormatException ex)
            {
                //Exception Occurs because the program exited without stoping the performance counters
            }

            this.updateChart();
            updateCount++;
        }

        //Initialize the chart settings and the DataTable
        private void setTableChart()
        {
            recordTable.Columns.Add("Count", typeof(int));
            recordTable.Columns.Add("Idle Time", typeof(float));
            recordTable.Columns.Add("Disk Time", typeof(float));
            recordTable.Columns.Add("Avg Disk Queue", typeof(float));
            recordTable.Columns.Add("Avg Transfer Req", typeof(float));

            HDchart.Series.Add("% Disk Idle Time (1)");
            HDchart.Series["% Disk Idle Time (1)"].ChartType = SeriesChartType.Line;
            HDchart.Series["% Disk Idle Time (1)"].XValueMember = "Count";
            HDchart.Series["% Disk Idle Time (1)"].YValueMembers = "Idle Time";

            HDchart.Series.Add("% Disk Time (10)");
            HDchart.Series["% Disk Time (10)"].ChartType = SeriesChartType.Line;
            HDchart.Series["% Disk Time (10)"].XValueMember = "Count";
            HDchart.Series["% Disk Time (10)"].YValueMembers = "Disk Time";

            HDchart.Series.Add("Avg. Disk Queue (100)");
            HDchart.Series["Avg. Disk Queue (100)"].ChartType = SeriesChartType.Line;
            HDchart.Series["Avg. Disk Queue (100)"].XValueMember = "Count";
            HDchart.Series["Avg. Disk Queue (100)"].YValueMembers = "Avg Disk Queue";

            HDchart.Series.Add("Avg. Transfer Req (1000)");
            HDchart.Series["Avg. Transfer Req (1000)"].ChartType = SeriesChartType.Line;
            HDchart.Series["Avg. Transfer Req (1000)"].XValueMember = "Count";
            HDchart.Series["Avg. Transfer Req (1000)"].YValueMembers = "Avg Transfer Req";

            HDchart.ChartAreas[0].AxisY.Maximum = 100;
            HDchart.ChartAreas[0].AxisX.Minimum = 0;
            HDchart.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Seconds;
            HDchart.ChartAreas[0].CursorX.IsUserEnabled = true;
            HDchart.ChartAreas[0].CursorX.AutoScroll = true;

            HDchart.DataSource = recordTable;
            HDchart.DataBind();
        }

        //Update the DataTable with new Data and Rebind to the chart
        private void updateChart()
        {
            recordTable.Rows.Add(updateCount, float.Parse(lblIdleTime.Text), float.Parse(lblDiskTime.Text) * 10,
                float.Parse(lblAvgDiskQ.Text) * 100, float.Parse(lblDiskReads.Text) * 1000);

            try
            {
                HDchart.DataBind();
            }
            catch (NullReferenceException ex)
            {
                //Occurs on forced exit
            }
        }

        //Stop Monitoring Destroy all the Counters to free Resources 
        private void btnStop_Click(object sender, EventArgs e)
        {

            stopW.Stop();
            stopW.Reset();

            perfCountObj.destroyCounters();

            btnStop.Enabled = false;
            btnStart.Enabled = true;
            this.disableButtons(false);
            
            timer.Dispose();
        }

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
                btnAvgTrans.Text = "Hiden";
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

        private void metroButton1_Click(object sender, EventArgs e)
        {
            perfCountObj = new PerfCounterHD(hostListComboBox.SelectedItem.ToString());

            btnStop.Enabled = true;
            btnStart.Enabled = false;

            lblTransMax.Text = "0.0";
            
            stopW.Start(); //ready the clock

            this.disableButtons(true);

            timer = new Timer { Enabled = true, Interval = 1000 };
            timer.Tick += t_Tick;
        }

        private void metroButton1_Click_1(object sender, EventArgs e)
        {
            stopW.Stop();
            stopW.Reset();

            perfCountObj.destroyCounters();

            btnStop.Enabled = false;
            btnStart.Enabled = true;
            this.disableButtons(false);
            
            timer.Dispose();
        }

        private void HDchart_Click(object sender, EventArgs e)
        {

        }

        private void lblDiskReads_Click(object sender, EventArgs e)
        {

        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
