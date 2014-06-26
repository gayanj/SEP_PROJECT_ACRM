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
    public partial class SystemMemoryInfo : Form
    {
        MEMORYSTATUSEX statusEx;
        public SystemMemoryInfo()
        {
            InitializeComponent();
        }

        private void SystemMemoryInfo_Load(object sender, EventArgs e)
        {
            statusEx = new MEMORYSTATUSEX();
            statusEx.setValues();
            ram_percentage.Text = statusEx.dwMemoryLoad.ToString() + " %";
            ram_totalPhysical.Text = statusEx.convertToBytes(statusEx.ullTotalPhys).ToString("0.00" + " MB");
            ram_availPhysical.Text = statusEx.convertToBytes(statusEx.ullAvailPhys).ToString("0.00" + " MB");
            ram_totalPage.Text = statusEx.convertToBytes(statusEx.ullTotalPageFile).ToString("0.00" + " MB");
            ram_availPage.Text = statusEx.convertToBytes(statusEx.ullAvailPageFile).ToString("0.00" + " MB");
            ram_totalVirtual.Text = statusEx.convertToBytes(statusEx.ullTotalVirtual).ToString("0.00" + " MB");
            ram_availVirtual.Text = statusEx.convertToBytes(statusEx.ullAvailVirtual).ToString("0.00" + " MB");
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            MemoryAnalytics m = new MemoryAnalytics();
            m.ShowDialog();
        }
    }
}
