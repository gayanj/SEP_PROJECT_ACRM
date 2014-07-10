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

namespace SEPMetro
{
    public partial class MemoryCounters : Form
    {
        Timer t;
        int count;
        public MemoryCounters()
        {
            InitializeComponent();
        }

        private void MemoryCounters_Load(object sender, EventArgs e)
        {
            t = new Timer { Enabled = true, Interval = 1000 };
            t.Tick += t_Tick;
            ram_PercentageCommitedBytesInUse.TextChanged += new EventHandler(this.t_Tick);
        }

        void t_Tick(object sender, EventArgs e)
        {
            PerformanceCounter mem1 = new PerformanceCounter("Memory", "% Committed Bytes In Use");
            var value1 = mem1.NextValue();
            ram_PercentageCommitedBytesInUse.Text = value1.ToString();

            PerformanceCounter mem2 = new PerformanceCounter("Memory", "Available KBytes");
            var value2 = mem2.NextValue();
            ram_AvailableBytes.Text = value2.ToString();

            PerformanceCounter mem3 = new PerformanceCounter("Memory", "Cache Bytes");
            var value3 = mem3.NextValue() / 1024;
            ram_CacheBytes.Text = value3.ToString();

            PerformanceCounter mem4 = new PerformanceCounter("Memory", "Cache Bytes Peak");
            var value4 = mem4.NextValue() / 1024;
            ram_CacheBytesPeak.Text = value4.ToString();

            PerformanceCounter mem5 = new PerformanceCounter("Memory", "Cache Faults/sec");
            var value5 = mem5.NextValue();
            ram_CacheFaults.Text = value5.ToString();

            PerformanceCounter mem6 = new PerformanceCounter("Memory", "Commit Limit");
            var value6 = mem6.NextValue() / 1024;
            ram_CommitLimit.Text = value6.ToString();

            PerformanceCounter mem7 = new PerformanceCounter("Memory", "Committed Bytes");
            var value7 = mem7.NextValue() / 1024;
            ram_CommitedBytes.Text = value7.ToString();

            PerformanceCounter mem8 = new PerformanceCounter("Memory", "Demand Zero Faults/sec");
            var value8 = mem8.NextValue();
            ram_DemandZeroFaults.Text = value8.ToString();

            PerformanceCounter mem9 = new PerformanceCounter("Memory", "Free & Zero Page List Bytes");
            var value9 = mem9.NextValue() / 1024;
            ram_FreeAndZeroFaults.Text = value9.ToString();

            PerformanceCounter mem10 = new PerformanceCounter("Memory", "Free System Page Table Entries");
            var value10 = mem10.NextValue() / 1024;
            ram_FreeSystemPage.Text = value10.ToString();

            PerformanceCounter mem11 = new PerformanceCounter("Memory", "Modified Page List Bytes");
            var value11 = mem11.NextValue() / 1024;
            ram_ModifiedPageListBytes.Text = value11.ToString();

            PerformanceCounter mem12 = new PerformanceCounter("Memory", "Page Faults/sec");
            var value12 = mem12.NextValue();
            ram_PageFaults.Text = value12.ToString();

            PerformanceCounter mem13 = new PerformanceCounter("Memory", "Page Reads/sec");
            var value13 = mem13.NextValue();
            ram_PageReads.Text = value13.ToString();

            PerformanceCounter mem14 = new PerformanceCounter("Memory", "Page Writes/sec");
            var value14 = mem14.NextValue();
            ram_PageWrites.Text = value14.ToString();

            PerformanceCounter mem15 = new PerformanceCounter("Memory", "Pages Input/sec");
            var value15 = mem15.NextValue();
            ram_PageInputs.Text = value15.ToString();

            PerformanceCounter mem16 = new PerformanceCounter("Memory", "Pages Output/sec");
            var value16 = mem16.NextValue();
            ram_PageOutputs.Text = value16.ToString();

            PerformanceCounter mem17 = new PerformanceCounter("Memory", "Pages/sec");
            var value17 = mem17.NextValue();
            ram_Pages.Text = value17.ToString();

            PerformanceCounter mem18 = new PerformanceCounter("Memory", "Write Copies/sec");
            var value18 = mem18.NextValue();
            ram_WriteCopies.Text = value18.ToString();

        }
    }
}
