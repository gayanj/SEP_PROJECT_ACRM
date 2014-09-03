using ACRMS.DISK;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ACRMS.CPU;

namespace ACRMS
{
    public partial class ACRMS_Main : Form
    {
        public ACRMS_Main()
        {
            InitializeComponent();
        }

        private void DISK_Button_Click(object sender, EventArgs e)
        {
            DiskMainGUI mainDiskWindow = new DiskMainGUI();
            mainDiskWindow.Show();
            mainDiskWindow.Focus();

        }

        private void CPU_Button_Click(object sender, EventArgs e)
        {
            CPU_Main_Window cpuMainWindow = new CPU_Main_Window();
            cpuMainWindow.Show();
            cpuMainWindow.Focus();
        }
    }
}
