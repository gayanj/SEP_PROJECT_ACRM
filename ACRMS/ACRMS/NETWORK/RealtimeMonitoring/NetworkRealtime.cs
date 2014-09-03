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
    public partial class NetworkRealtime : Form
    {
        Timer t;
        NetworkMonitor nm = new NetworkMonitor();
        DataTable dt = new DataTable();
        public NetworkRealtime()
        {
            InitializeComponent();
            BackgroundWorker startMonitoring;
            startMonitoring = new BackgroundWorker();
            startMonitoring.DoWork += new DoWorkEventHandler(startMonitoring_DoWork);
            startMonitoring.RunWorkerAsync();
            dt = nm.getData();
            dataGridView1.DataSource = dt;
            t = new Timer { Enabled = true, Interval = 1000 };
            t.Tick += t_Tick;
        }

        void t_Tick(object sender, EventArgs e)
        {
            DataTable newdt = nm.getData();
            int rowcount = newdt.Rows.Count;
            for (int i = 0; i < rowcount; rowcount--)
            {
                string x = newdt.Rows[i][1].ToString();
                bool contains = dt.AsEnumerable().Any(row => newdt.Rows[i][1].ToString() == row.Field<String>("PID"));
                if (contains)
                {
                    var dr = dt.Select("PID = '" + newdt.Rows[i][1].ToString() + "'").FirstOrDefault();
                    dr[2] = newdt.Rows[i][2].ToString(); 
                }
            }
        }

        private void startMonitoring_DoWork(object sender, DoWorkEventArgs e)
        {
            nm.MonitorNetwork();
        }
    }
}
