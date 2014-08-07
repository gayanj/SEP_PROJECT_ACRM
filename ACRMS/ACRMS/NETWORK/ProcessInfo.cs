using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using netwatch;

namespace SEPMetro
{
    public partial class ProcessInfo : Form
    {
        private System.ComponentModel.Container components = null;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;

        private IpHlpApidotnet.IPHelper MyAPI;

        private const int MIB_TCP_RTO_CONSTANT = 2;
        private const int MIB_TCP_RTO_OTHER = 1;
        private const int MIB_TCP_RTO_RSRE = 3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button7;
        private const int MIB_TCP_RTO_VANJ = 4;
        public ProcessInfo()
        {
            InitializeComponent();
            MyAPI = new IpHlpApidotnet.IPHelper();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.listBox1.Items.Clear();
            MyAPI.GetTcpStats();
            string m_algo = "";
            switch (MyAPI.TcpStats.dwRtoAlgorithm)
            {
                case 1: m_algo = "Other"; break;
                case 2: m_algo = "Constant Time-out"; break;
                case 3: m_algo = "MIL-STD-1778 Appendix B"; break;
                case 4: m_algo = "Van Jacobson's Algorithm"; break;
            }
            this.listBox1.Items.Add(string.Format("{0} : {1}", "RtoAlgorithm", m_algo));
            this.listBox1.Items.Add(string.Format("{0} : {1}", "RtoMin", MyAPI.TcpStats.dwRtoMin.ToString()));
            this.listBox1.Items.Add(string.Format("{0} : {1}", "RtoMax", MyAPI.TcpStats.dwRtoMax.ToString()));
            this.listBox1.Items.Add(string.Format("{0} : {1}", "Max Connection", MyAPI.TcpStats.dwMaxConn.ToString()));
            this.listBox1.Items.Add(string.Format("{0} : {1}", "Active Open Connection", MyAPI.TcpStats.dwActiveOpens.ToString()));
            this.listBox1.Items.Add(string.Format("{0} : {1}", "Passive Open Connection", MyAPI.TcpStats.dwPassiveOpens.ToString()));
            this.listBox1.Items.Add(string.Format("{0} : {1}", "Attempte Fail", MyAPI.TcpStats.dwAttemptFails.ToString()));
            this.listBox1.Items.Add(string.Format("{0} : {1}", "Estabished connection that have been reset", MyAPI.TcpStats.dwEstabResets.ToString()));
            this.listBox1.Items.Add(string.Format("{0} : {1}", "Current estabished connection", MyAPI.TcpStats.dwCurrEstab.ToString()));
            this.listBox1.Items.Add(string.Format("{0} : {1}", "In Segments", MyAPI.TcpStats.dwInSegs.ToString()));
            this.listBox1.Items.Add(string.Format("{0} : {1}", "Out Segement", MyAPI.TcpStats.dwOutSegs.ToString()));
            this.listBox1.Items.Add(string.Format("{0} : {1}", "Segement Retransmitted", MyAPI.TcpStats.dwRetransSegs.ToString()));
            this.listBox1.Items.Add(string.Format("{0} : {1}", "InErrors", MyAPI.TcpStats.dwInErrs.ToString()));
            this.listBox1.Items.Add(string.Format("{0} : {1}", "number of segments transmitted with the reset flag set", MyAPI.TcpStats.dwRetransSegs.ToString()));
            this.listBox1.Items.Add(string.Format("{0} : {1}", "number of connections", MyAPI.TcpStats.dwNumConns.ToString()));
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            this.listBox1.Items.Clear();
            MyAPI.GetUdpStats();
            this.listBox1.Items.Add(string.Format("{0} : {1}", "In Datagrams", MyAPI.UdpStats.dwInDatagrams.ToString()));
            this.listBox1.Items.Add(string.Format("{0} : {1}", "Out Datagrams", MyAPI.UdpStats.dwOutDatagrams.ToString()));
            this.listBox1.Items.Add(string.Format("{0} : {1}", "In Errors", MyAPI.UdpStats.dwInErrors.ToString()));
            this.listBox1.Items.Add(string.Format("{0} : {1}", "No Ports", MyAPI.UdpStats.dwNoPorts.ToString()));
            this.listBox1.Items.Add(string.Format("{0} : {1}", "Num Address", MyAPI.UdpStats.dwNumAddrs.ToString()));
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            this.listBox1.Items.Clear();
            //this.listBox1.Items.Clear();
            //MyAPI.GetTcpConnexions();
            //for(int i=0;i<MyAPI.TcpConnexion.dwNumEntries;i++)
            //{
            //    this.listBox1.Items.Add(string.Format("{0} \t\t {1} \t\t\t  {2}",
            //        MyAPI.TcpConnexion.table[i].Local.Address.ToString()+":"+MyAPI.TcpConnexion.table[i].Local.Port.ToString(),
            //        MyAPI.TcpConnexion.table[i].Remote.Address.ToString()+":"+MyAPI.TcpConnexion.table[i].Remote.Port.ToString(),
            //        MyAPI.TcpConnexion.table[i].StrgState.ToString()));
            //}
            this.listBox1.Items.Add("Active Connections\n\n");
            this.listBox1.Items.Add("  Proto \t  Local Address          Foreign Address        State         PID\n");
            foreach (TcpRow tcpRow in ManagedIpHelper.GetExtendedTcpTable(true))
            {
                this.listBox1.Items.Add(string.Format("  {0,-7}\t{1,-23}{2, -23}{3,-14}{4}", "TCP", tcpRow.LocalEndPoint, tcpRow.RemoteEndPoint, tcpRow.State, tcpRow.ProcessId));
                try
                {
                    Process process = Process.GetProcessById(tcpRow.ProcessId);
                    if (process.ProcessName != "System")
                    {
                        //foreach (ProcessModule processModule in process.Modules)
                        //{
                        //    Console.WriteLine("  {0}", processModule.FileName);
                        //}
                        try
                        {
                            this.listBox1.Items.Add(string.Format("  [{0}]", Path.GetFileName(process.MainModule.FileName)));
                        }
                        catch (Exception ex)
                        {
                        }
                    }
                    else
                    {
                        this.listBox1.Items.Add(string.Format("  -- unknown component(s) --"));
                        this.listBox1.Items.Add(string.Format("  [{0}]", "System"));
                    }

                    this.listBox1.Items.Add("");
                }
                catch (Exception ex)
                {
                    listBox1.Items.Add("unknown components");
                }
            }
        }
    }
}
