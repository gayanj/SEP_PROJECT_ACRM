using System;
using System.Diagnostics;
using System.Windows.Forms;

using ACRMS.DISK.DiskMonitorBundle;

namespace ACRMS.DISK.IntelliMon
{
    using System.IO;

    using ACRMS.DISK.DiskDataHandler;

    public partial class MonitorWindow : Form
    {
        private int index;
        private string hostName;
        private string hostIp;
        private Stopwatch stw;
        private Timer timer;
        private LogTextWriter logTextWriter;

        public MonitorWindow(int queueIndex)
        {
            this.hostName = DiskDataQueue.GetHostName(queueIndex);
            this.hostIp = DiskDataQueue.GetHostIp(queueIndex);
            this.index = queueIndex;
            DiskDataQueue.AddForm(queueIndex, this);

            InitializeComponent();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            DiskDataQueue.DequeueDiskData(this.index);
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

            lblClientIp.Text = this.hostIp;
            lblClientName.Text = this.hostName;
            logTextWriter = new LogTextWriter(this.hostName,this.hostIp);

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lblTimer.Text = stw.Elapsed.ToString().Substring(0, 8);
            logTextWriter.Log();
        }
    }
}