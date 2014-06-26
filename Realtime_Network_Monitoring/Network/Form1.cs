using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Network
{
    public partial class Form1 : Form
    {
        Timer t;
        NetworkMonitor nm = new NetworkMonitor();
        DataTable dt = new DataTable();
        public Form1()
        {
            InitializeComponent();
            BackgroundWorker startMonitoring;
            startMonitoring = new BackgroundWorker();
            startMonitoring.DoWork += new DoWorkEventHandler(startMonitoring_DoWork);
            startMonitoring.RunWorkerAsync();
            DatabaseFactory.connectToDatabase();
            t = new Timer { Enabled = true, Interval = 2000 };
            t.Tick += t_Tick;
        }

        void t_Tick(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = nm.getData();
        }

        private void startMonitoring_DoWork(object sender, DoWorkEventArgs e)
        {
            nm.MonitorNetwork();
        }
    }
}
