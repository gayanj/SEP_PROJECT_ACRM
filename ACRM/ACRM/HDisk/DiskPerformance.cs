using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ACRM.HDisk
{
    public partial class DiskPerformance : Form
    {
        PerfCounterHD pc;
        public DiskPerformance()
        {
            
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            pc = new PerfCounterHD();
            lblTransMax.Text = "0.0";
            Timer t = new Timer { Enabled = true, Interval = 1000 };
            t.Tick += t_Tick;
        }

        void t_Tick(object sender, EventArgs e)
        {
            lblDiskReads.Text = pc.getDiskRead().ToString();
            lblDiskWrites.Text = pc.getDiskWrites().ToString();
            lblDiskTrans.Text = pc.getDiskTransfer().ToString();

            lblDiskReadsBytes.Text = ExtraDiskMeth.SizeSuffix(pc.getDiskReadsBytes().ToString());
            lblDiskWriteBytes.Text = ExtraDiskMeth.SizeSuffix(pc.getDiskWritesBytes().ToString());
            lblDiskTransByte.Text = ExtraDiskMeth.SizeSuffix(pc.getDiskTransBytes().ToString());

            if ( float.Parse(lblTransMax.Text) < float.Parse(lblDiskTrans.Text))
            {
                lblTransMax.Text = lblDiskTrans.Text;
                lblTransMax.BackColor = Color.Red;
            }
        }

    }
}
