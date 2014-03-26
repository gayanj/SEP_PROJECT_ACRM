using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RAM
{
    public partial class Form1 : Form
    {
        MEMORYSTATUSEX statusEx;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            statusEx = new MEMORYSTATUSEX();
            statusEx.setValues();
            percentageLabel.Text = statusEx.dwMemoryLoad.ToString()+" %";
            totalPhysicalLabel.Text = statusEx.convertToBytes(statusEx.ullTotalPhys).ToString("0.00"+" MB");
            availPhysicalLabel.Text = statusEx.convertToBytes(statusEx.ullAvailPhys).ToString("0.00"+" MB");
            totalPageLabel.Text = statusEx.convertToBytes(statusEx.ullTotalPageFile).ToString("0.00"+" MB");
            availPageLabel.Text = statusEx.convertToBytes(statusEx.ullAvailPageFile).ToString("0.00"+" MB");
            totalVirtualLabel.Text = statusEx.convertToBytes(statusEx.ullTotalVirtual).ToString("0.00"+" MB");
            availVirtualLabel.Text = statusEx.convertToBytes(statusEx.ullAvailVirtual).ToString("0.00"+" MB");
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

    }
}
