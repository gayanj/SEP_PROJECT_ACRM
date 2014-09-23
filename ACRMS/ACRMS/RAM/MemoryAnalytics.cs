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

namespace SEPMetro
{
    public partial class MemoryAnalytics : Form
    {
        public MemoryAnalytics()
        {
            InitializeComponent();
            ProcessList p = new ProcessList();
        }

        private void ram_RunningApps_Click(object sender, EventArgs e)
        {
            ram_analytics.Text = string.Empty;
            ram_analytics.Text = ProcessList.ListAllApplications();
        }

        private void ram_ViewProcesses_Click(object sender, EventArgs e)
        {
            ram_analytics.Text = string.Empty;
            ram_analytics.Text = ProcessList.ListAllProcesses();
        }

        private void ram_ViewImages_Click(object sender, EventArgs e)
        {
            ram_analytics.Text = string.Empty;
            ram_analytics.Text = ProcessList.ListAllByImageName();
        }
    }
}
