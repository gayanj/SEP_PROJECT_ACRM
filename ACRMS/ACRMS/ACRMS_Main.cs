using ACRMS.DISK;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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
    }
}
