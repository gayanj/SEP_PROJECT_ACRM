using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ACRM.RAM;

namespace SEPMetro
{
    public partial class IdleCheckForm : Form
    {
        private System.Windows.Forms.Timer timer1;
        private long idleCounter = 0;
        public IdleCheckForm()
        {
            InitializeComponent();

            int cpuPct = (int)(ApplicationIdleTimer.CPUUsageThreshold * 100.0);

            this.ram_adjThreshold.Value = (int)ApplicationIdleTimer.GUIActivityThreshold;
            this.ram_guiThreshold.Text = this.ram_adjThreshold.Value.ToString("#0.0");

            // Listen for changes
          //  this.ram_adjThreshold.Scroll += new System.EventHandler(this.adjGUIThreshold_Scroll);
            this.ram_adjThreshold.Scroll += new ScrollEventHandler(this.adjGUIThreshold_Scroll);


            // Hook into the ApplicationIdle event
            ApplicationIdleTimer.ApplicationIdle += new ApplicationIdleTimer.ApplicationIdleEventHandler(this.App_Idle);

            // Also hook into the Application.Idle event, for comparison

            // Start the timer
            timer1 = new System.Windows.Forms.Timer();
            timer1.Interval = 250;
            timer1.Tick += new System.EventHandler(this.timer1_Tick);
            timer1.Start();
        }

        private void IdleCheckForm_Load(object sender, EventArgs e)
        {

        }

        private void App_Idle(ApplicationIdleTimer.ApplicationIdleEventArgs e)
        {
            this.ram_status.BackColor = Color.Green;
            this.ram_status.Text = string.Format("Idle: {0}s", e.IdleDuration.TotalSeconds.ToString("0"));
        }

        private void Idle_Count(object sender, System.EventArgs e)
        {
            idleCounter++;
        }

        private void adjGUIThreshold_Scroll(object sender, System.EventArgs e)
        {
            double val = (double)this.ram_adjThreshold.Value;
            this.ram_guiThreshold.Text = val.ToString("#0.0");
            ApplicationIdleTimer.GUIActivityThreshold = val;
        }

        private void timer1_Tick(object sender, System.EventArgs e)
        {
            if (!ApplicationIdleTimer.IsIdle && this.ram_status.Text != "Busy")
            {
                this.ram_status.BackColor = Color.Red;
                this.ram_status.Text = "Busy";
            }

            this.ram_guiActivity.Text = ApplicationIdleTimer.CurrentGUIActivity.ToString("#0.0");
            this.ram_appIdleEvents.Text = idleCounter.ToString("#,##0");

        }
    }
}
