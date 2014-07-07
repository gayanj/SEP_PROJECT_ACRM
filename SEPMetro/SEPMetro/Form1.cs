using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SEPMetro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void RAM_Click(object sender, EventArgs e)
        {
            RAM r = new RAM();
            r.ShowDialog();
        }

        private void CPU_Click(object sender, EventArgs e)
        {
            ACRM.ACRMForm c = new ACRM.ACRMForm();
            c.ShowDialog();
        }

        private void metroDiskTile_Click(object sender, EventArgs e)
        {
            DiskMonitorMain dmm = new DiskMonitorMain();
            dmm.Show();
            dmm.Focus();
        }
    }
}
