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
        Timer t;
        public DiskPerformance()
        {
            
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStop.Enabled = true;
            btnStart.Enabled = false;
            pc = new PerfCounterHD();
            lblTransMax.Text = "0.0";
            t = new Timer { Enabled = true, Interval = 1000 };
            t.Tick += t_Tick;
        }

        void t_Tick(object sender, EventArgs e)
        {
            lblDiskReads.Text = pc.DiskReads.ToString();
            lblDiskWrites.Text = pc.DiskWrites.ToString();
            lblDiskTrans.Text = pc.DiskTransfers.ToString();

            lblDiskReadsBytes.Text = ExtraDiskMeth.SizeSuffix(pc.DiskReadsB.ToString());
            lblDiskWriteBytes.Text = ExtraDiskMeth.SizeSuffix(pc.AvgDiskWriteB.ToString());
            lblDiskTransByte.Text = ExtraDiskMeth.SizeSuffix(pc.DiskTransB.ToString());

            lblAvgRead.Text = pc.AvgDiskRead.ToString();
            lblAvgWrite.Text = pc.AvgDiskWrite.ToString();
            lblAvgTrans.Text = pc.AvgDiskTrans.ToString();

            lblAvgReadB.Text = ExtraDiskMeth.SizeSuffix(pc.AvgDiskReadB.ToString());
            lblAvgWriteB.Text = ExtraDiskMeth.SizeSuffix(pc.AvgDiskWriteB.ToString());
            lblAvgTransB.Text = ExtraDiskMeth.SizeSuffix(pc.AvgDiskTransB.ToString());

            lblCurrQLen.Text = pc.CurrQueueLen.ToString();
            lblAvgReadQ.Text = pc.AvgDiskReadQueue.ToString();
            lblAvgWriteQ.Text = pc.AvgDiskWriteQueue.ToString();
            lblAvgDiskQ.Text = pc.AvgDiskQueue.ToString();

            lblIOSplit.Text = pc.DiskIOSplit.ToString();
            lblDiskTime.Text = pc.DiskTime.ToString();
            lblIdleTime.Text = pc.DiskIdleTime.ToString();
            lblReadTime.Text = pc.DiskReadTime.ToString();
            lblWriteTime.Text = pc.DiskWriteTime.ToString();

            try
            {
                if (float.Parse(lblTransMax.Text) < float.Parse(lblDiskTrans.Text))
                {
                    lblTransMax.Text = lblDiskTrans.Text;
                    lblTransMax.BackColor = Color.Red;
                }
            }
            catch (FormatException ex)
            {
                //Exception Occurs because the program exited without stoping the performance counters
            }

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            pc.destroyCounters();
            btnStop.Enabled = false;
            btnStart.Enabled = true;
            t.Dispose();
        }

        private void DiskPerformance_Load(object sender, EventArgs e)
        {
            btnStop.Enabled = false;
        }

    }
}
