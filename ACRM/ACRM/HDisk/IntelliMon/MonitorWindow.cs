using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACRM.HDisk.IntelliMon
{
    public partial class MonitorWindow : Form
    {
        PerfCounterHD perfCounter;
        Timer timer;
        Stopwatch stw;
        private string client;
        private string clientIp;

        public MonitorWindow(string clientName, string clientIp)
        {
            this.client = clientName;
            this.clientIp = clientIp;
            perfCounter = new PerfCounterHD(clientName);
            InitializeComponent();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            perfCounter.destroyCounters();
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
