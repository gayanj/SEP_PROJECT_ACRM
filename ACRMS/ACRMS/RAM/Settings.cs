using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RAM;
using SEPMetro;

namespace ACRMS
{
    public partial class Settings : Form
    {
        public static int chromeAlertTime;
        public static int chromeMemoryUsage;
        public static int IEAlertTime;
        public static int IEMemoryUsage;
        public static int idleCheckerTime;
        public static int guiActivityThreshold;
        public static int idleTimeThrashold;
        public static int liveInfoTime;
        public static bool committedBytealert;
        public static int ramPercentageAlert;
        public static int ramAlertTime;
        public static int runningAppTime;
        public static int runningApplicationThreshold;
        public static string processExists;
        public static bool guistate;
        public static bool killProcess;


        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            chromeAlertTime = 5000;
            chromeMemoryUsage = 500;
            IEAlertTime = 5000;
            IEMemoryUsage=500;
            idleCheckerTime = 5000;
            guiActivityThreshold = 200;
            idleTimeThrashold = 400;
            liveInfoTime=5000;
            committedBytealert = committedBytesAlert.Checked;
            ramAlertTime=5000;
            ramPercentageAlert=80;
            runningAppTime=5000;
            runningApplicationThreshold = 500;
            processExists = processRunning.Text;
            chromeTime.Text = "5";
            chromeThreshold.Text = "300";
            IETime.Text = "5";
            chromeThreshold.Text = "5";
            idleAlertTime.Text = "5";
            GuiAlertThreshold.Text = "400";
            liveInfoAlertTime.Text = "5";
            ramTime.Text = "5";
            ramPercentageThreshold.Text = "90";
            appAlertTime.Text = "5";
            appAlertThreshold.Text = "300";
            processRunning.Text = "devenv.exe";

        }

        private void saveChanges_Click(object sender, EventArgs e)
        {
            chromeAlertTime = Int32.Parse(chromeTime.Text)*1000;
            chromeMemoryUsage = Int32.Parse(chromeThreshold.Text);
            IEAlertTime = Int32.Parse(IETime.Text)*1000;
            IEMemoryUsage = Int32.Parse(chromeThreshold.Text);
            idleCheckerTime = Int32.Parse(idleAlertTime.Text)*1000;
            guiActivityThreshold = Int32.Parse(GuiAlertThreshold.Text);
            liveInfoTime = Int32.Parse(liveInfoAlertTime.Text)*1000;
            committedBytealert = committedBytesAlert.Checked;
            ramAlertTime = Int32.Parse(ramTime.Text)*1000;
            ramPercentageAlert = Int32.Parse(ramPercentageThreshold.Text);
            runningAppTime = Int32.Parse(appAlertTime.Text)*1000;
            runningApplicationThreshold = Int32.Parse(appAlertThreshold.Text);
            processExists = processRunning.Text;
            if (guiAlertCheckbox.Checked)
                guistate = true;
            else
                guistate = false;
            if  (committedBytesAlert.Checked)
                committedBytealert=true;
            else
                committedBytealert=false;
            if (killProcessCheckbox.Checked)
                killProcess = true;
            else
                killProcess = false;

            Browser b = new Browser();
            IdleCheckForm i = new IdleCheckForm();
            MemoryCounters m = new MemoryCounters();
            SystemMemoryInfo s = new SystemMemoryInfo();
            ProcessList p = new ProcessList();

            this.Close();

        }

        private void ramCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void metroCheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
