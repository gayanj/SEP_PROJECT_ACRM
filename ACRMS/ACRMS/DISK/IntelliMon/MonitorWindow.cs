using System;
using System.Diagnostics;
using System.Windows.Forms;

using ACRMS.DISK.DiskMonitorBundle;

namespace ACRMS.DISK.IntelliMon
{
    public partial class MonitorWindow : Form
    {
        private string client;
        private string clientIp;
        private PerfCounterHD perfCounter;
        private Stopwatch stw;
        private Timer timer;

        public MonitorWindow(string clientName, string clientIp)
        {
            this.client = clientName;
            this.clientIp = clientIp;
            perfCounter = new PerfCounterHD(clientName);
            InitializeComponent();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            perfCounter.DestroyCounters();
            stw.Stop();
            stw.Reset();
            timer.Dispose();
            this.Close();
        }

        private void MonitorWindow_Load(object sender, EventArgs e)
        {
            timer = new Timer { Enabled = true, Interval = 1000 };
            timer.Tick += timer_Tick;

            stw = new Stopwatch();
            stw.Start();

            lblClientIp.Text = this.clientIp;
            lblClientName.Text = this.client;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lblTimer.Text = stw.Elapsed.ToString().Substring(0, 8);
        }
    }
}