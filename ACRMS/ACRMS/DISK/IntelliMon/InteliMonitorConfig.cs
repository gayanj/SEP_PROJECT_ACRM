using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace ACRMS.DISK.IntelliMon
{
    public partial class InteliMonitorConfig : Form
    {
        Timer timer;
        MonitorWindow mw;

        public InteliMonitorConfig()
        {
            InitializeComponent();
        }
                
        private void InteliMonitorConfig_Load(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(@"D:\watchlist.xml", FileMode.Open, FileAccess.Read);
            dsWatchlist.ReadXml(fs);
            dgvWatchList.DataSource = dsWatchlist.Tables[0];
            foreach (DataGridViewRow row in dgvWatchList.Rows)
            {
                row.Cells[0].Value = "Start";
                row.Cells[1].Value = "Remove";
                row.Cells[2].Value = "Enable";
            }
            dgvWatchList.Refresh();

            timer = new Timer { Enabled = true, Interval = 1000 };
            timer.Tick += timer_Tick;

            btnAddClientMnul.Enabled = false;
            btnAddClient.Enabled = false;

        }

        void timer_Tick(object sender, EventArgs e)
        {
            this.updateStatusLbl();
        }

        private void btnScanNetwork_Click(object sender, EventArgs e)
        {
            int count = 0;
            string hostName = Dns.GetHostName();
            IPHostEntry ipHostEntry = Dns.GetHostEntry(hostName);

            foreach (IPAddress ipAddr in ipHostEntry.AddressList)
            {
                if (ipAddr.AddressFamily == AddressFamily.InterNetwork)
                {
                    IPHostEntry remoteAdd = Dns.GetHostEntry(ipAddr);
                    listBoxClientList.Items.Add(remoteAdd.AddressList[count].ToString());
                }
                count++;
            }
            listBoxClientList.SelectedIndex = 0;
            btnAddClient.Enabled = true;
        }

        private void btnManSearch_Click(object sender, EventArgs e)
        {
            string client = txtClientAddrs.Text.ToString();
            try
            {
                IPHostEntry remoteAdd = Dns.GetHostEntry(client);
                lblHostName.Text = remoteAdd.HostName.ToString();
                lblHostIp.Text = client;
            }
            catch (SocketException ex)
            {
                MessageBox.Show("Invalid Address or Host Name. Please Recheck and Try Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            btnAddClientMnul.Enabled = true;
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            string clientIp;
            string clientName;
            string hostName;
            string hostIp;

            clientIp = listBoxClientList.SelectedItem.ToString();
            IPHostEntry remoteadd = Dns.GetHostEntry(clientIp);
            clientName = remoteadd.HostName.ToString();
            hostName = Dns.GetHostName();
            Ping ping = new Ping();
            PingReply pingReply = ping.Send(hostName);
            hostIp = pingReply.Address.ToString();

            dsWatchlist.Tables[0].Rows.Add(clientName, clientIp, hostIp, DateTime.Now.Date.ToString().Substring(0,9), false);

            dgvWatchList.DataSource = dsWatchlist.Tables[0];

            foreach (DataGridViewRow row in dgvWatchList.Rows)
            {
                row.Cells[0].Value = "Start";
                row.Cells[1].Value = "Remove";
                row.Cells[2].Value = "Enable";
            }
            dgvWatchList.Refresh();
        }

        private void btnAddClientMnul_Click(object sender, EventArgs e)
        {
            string clientIp;
            string clientName;
            string hostName;
            string hostIp;

            clientIp = lblHostIp.Text;
            IPHostEntry remoteadd = Dns.GetHostEntry(clientIp);
            clientName = remoteadd.HostName.ToString();
            hostName = Dns.GetHostName();
            Ping ping = new Ping();
            PingReply pingReply = ping.Send(hostName);
            hostIp = pingReply.Address.ToString();

            dsWatchlist.Tables[0].Rows.Add(clientName, clientIp, hostIp, DateTime.Now.Date.ToString().Substring(0,9), true);

            dgvWatchList.DataSource = dsWatchlist.Tables[0];

            foreach (DataGridViewRow row in dgvWatchList.Rows)
            {
                row.Cells[0].Value = "Start";
                row.Cells[1].Value = "Remove";
                row.Cells[2].Value = "Enable";
            }
            dgvWatchList.Refresh();
        }

        private void dgvWatchList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                if (dsWatchlist.Tables[0].Rows[e.RowIndex][4].Equals(true))
                {
                    mw = new MonitorWindow(dsWatchlist.Tables[0].Rows[e.RowIndex].ItemArray[0].ToString(), 
                        dsWatchlist.Tables[0].Rows[e.RowIndex].ItemArray[1].ToString());

                    dgvWatchList.Refresh();
                    mw.Show();
                    mw.Focus();
                }
                else
                {
                    MessageBox.Show("Monitoring is Disabled");
                }
            }
            if (e.ColumnIndex == 1)
            {
                dsWatchlist.Tables[0].Rows[e.RowIndex].Delete();
                dgvWatchList.Refresh();
            }

            if (e.ColumnIndex == 2)
            {
                if (dsWatchlist.Tables[0].Rows[e.RowIndex][4].Equals(true))
                {
                    dsWatchlist.Tables[0].Rows[e.RowIndex][4] = false;
                    dgvWatchList.Rows[e.RowIndex].Cells[2].Value = "Enable";
                    dgvWatchList.Refresh();
                }
                else
                {
                    if (dsWatchlist.Tables[0].Rows[e.RowIndex][4].Equals(false))
                    {
                        dsWatchlist.Tables[0].Rows[e.RowIndex][4] = true;
                        dgvWatchList.Rows[e.RowIndex].Cells[2].Value = "Disable";
                        dgvWatchList.Refresh();
                    }
                }
            }
        }

        private int isMonitorWindowExists()
        {
            FormCollection fc = Application.OpenForms;
            int count = 0;
            foreach (Form frm in fc)
            {
                if (frm.Name == "MonitorWindow")
                {
                    count++;
                }
            }
            return count;
        }

        private void updateStatusLbl()
        {
            int noOfMonitorInstances = this.isMonitorWindowExists();

            lblStatus.Text = "Monitoring for " + noOfMonitorInstances + " Clients";

            if (noOfMonitorInstances == 0)
            {
                lblStatus.BackColor = Color.Red;
            }
            else
            {
                lblStatus.BackColor = Color.Green;
            }
        }

        private void InteliMonitorConfig_FormClosing(object sender, FormClosingEventArgs e)
        {
            XmlSerializer xml = new XmlSerializer(typeof(DataSet));
            
            try
            {
                FileStream fs = new FileStream(@"D:\watchlist.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                xml.Serialize(fs, dsWatchlist);
            }
            catch (Exception ex)
            {

            }
        }
    }
}
