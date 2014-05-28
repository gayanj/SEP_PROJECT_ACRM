using ACRM.HDisk.IntelliMon;
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

namespace ACRM.HDisk
{
    public partial class DiskPerformance : Form
    {
        //Form sometime may not initialize currectly in the IDE due to Windows Charting function not supporting .Net 3.5 Framework in Visual Studio 2012 JUST IGONRE AND CONTINUE
        PerfCounterHD perfCountObj;
        Timer timer;
        DataTable recordTable;
        Stopwatch stopW;
        int updateCount;

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

            toolStripStatusLabel1.Text = "Ready To Begain";
            statusStrip1.Refresh();            

            this.setTableChart();
            this.fillHostList();
        }
                
        //Start Monitoring
        private void btnStart_Click(object sender, EventArgs e)
        {
            perfCountObj = new PerfCounterHD(hostListComboBox.SelectedItem.ToString());

            btnStop.Enabled = true;
            btnStart.Enabled = false;            

            lblTransMax.Text = "0.0";
            toolStripStatusLabel1.Text = "Currently Monitoring";
            statusStrip1.Refresh();

            stopW.Start(); //ready the clock

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
            lblAvgTrans.Text = perfCountObj.AvgDiskTrans.ToString();

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

            HDchart.Series.Add("% Disk Time (100)");
            HDchart.Series["% Disk Time (100)"].ChartType = SeriesChartType.Line;
            HDchart.Series["% Disk Time (100)"].XValueMember = "Count";
            HDchart.Series["% Disk Time (100)"].YValueMembers = "Disk Time";

            HDchart.Series.Add("Avg. Disk Queue");
            HDchart.Series["Avg. Disk Queue"].ChartType = SeriesChartType.Line;
            HDchart.Series["Avg. Disk Queue"].XValueMember = "Count";
            HDchart.Series["Avg. Disk Queue"].YValueMembers = "Avg Disk Queue";

            HDchart.Series.Add("Avg. Transfer Req");
            HDchart.Series["Avg. Transfer Req"].ChartType = SeriesChartType.Line;
            HDchart.Series["Avg. Transfer Req"].XValueMember = "Count";
            HDchart.Series["Avg. Transfer Req"].YValueMembers = "Avg Transfer Req";

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
            recordTable.Rows.Add(updateCount, float.Parse(lblIdleTime.Text), float.Parse(lblDiskTime.Text)*10,
                float.Parse(lblAvgDiskQ.Text)*100, float.Parse(lblAvgTrans.Text)*1000);

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
            toolStripStatusLabel1.Text = "Monitoring Stopped";
            statusStrip1.Refresh();

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
    }
}
