using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SEPMetro
{
    public partial class NetworkCore : Form
    {
        private NetworkInterface[] nics = null;
        private Boolean monitoring = false;
        private Thread wrkerthread = null;
        delegate void SetTextCallback(string text);
        public NetworkCore()
        {
            InitializeComponent();
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int count = 0;
            listBox1.Items.Clear();
            if (nics == null)
            {
                nics = NetworkInterface.GetAllNetworkInterfaces();
            }
            foreach (NetworkInterface adapter in nics)
            {
                if ((adapter.GetIPv4Statistics().BytesReceived > 0) && (!adapter.Description.Contains("Teredo")))
                {
                    count++;
                    this.SetText(adapter.Description);
                    this.SetText(String.Empty.PadLeft(adapter.Description.Length, '='));
                }
            }
            label39.Text = "Total No of network Interfaces found : " + count;
            listBox1.Visible = true;
        }
        private void SetText(string information)
        {
            if (listBox1.InvokeRequired)
            {

                SetTextCallback d = new SetTextCallback(SetText);
                try
                {
                    this.Invoke(d, new object[] { information });

                }
                catch (ObjectDisposedException e) {   }
            }
            else
            {
                if (information.Equals("clear"))
                {
                    listBox1.Items.Clear();
                }
                else
                {
                    listBox1.Items.Add(information);
                    
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (nics != null)
            {
                monitoring = true;

                wrkerthread = new Thread(new ThreadStart(this.ThreadProcSafe));
                wrkerthread.Start();
            }
        }

        private void ThreadProcSafe()
        {
            while (monitoring)
            {
                this.SetText("clear");
                nics = NetworkInterface.GetAllNetworkInterfaces();
                foreach (NetworkInterface adapter in nics)
                {
                    if ((adapter.GetIPv4Statistics().BytesReceived > 0) && (!adapter.Description.Contains("Teredo")))
                    {

                        this.SetText(adapter.Description);
                        this.SetText(String.Empty.PadLeft(adapter.Description.Length, '='));
                        this.SetText("Interface type ................................ : " + adapter.NetworkInterfaceType);
                        this.SetText("Physical Address .......................... : " + adapter.GetPhysicalAddress());
                        this.SetText("Operational status ....................... : " + adapter.OperationalStatus);
                        string versions = "";
                        if (adapter.Supports(NetworkInterfaceComponent.IPv4))
                        {
                            versions = "IPv4   ";
                        }
                        if (adapter.Supports(NetworkInterfaceComponent.IPv6))
                        {
                            versions += "IPv6";
                        }
                        this.SetText("IP version ...................................... : " + versions);
                        this.SetText("    Bytes Sent: " + adapter.GetIPv4Statistics().BytesSent);
                        this.SetText("    Bytes Received: " + adapter.GetIPv4Statistics().BytesReceived);
                        IPInterfaceProperties properties = adapter.GetIPProperties();
                        this.SetText("DNS enabled .......................................... : " + properties.IsDnsEnabled);
                        this.SetText("Dynamically configured DNS ................... : " + properties.IsDynamicDnsEnabled);
                        this.SetText("Receive Only .......................................... : " + adapter.IsReceiveOnly);
                        this.SetText("Multicast ................................................. : " + adapter.SupportsMulticast);
                    }
                    Console.WriteLine("\n");
                }

                Thread.Sleep(1000);

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            monitoring = false;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            ProcessInfo p_if = new ProcessInfo();
            p_if.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            int count = 0;
            listBox1.Items.Clear();
            if (nics == null)
            {
                nics = NetworkInterface.GetAllNetworkInterfaces();
            }
            foreach (NetworkInterface adapter in nics)
            {
                if ((adapter.GetIPv4Statistics().BytesReceived > 0) && (!adapter.Description.Contains("Teredo")))
                {
                    count++;
                    this.SetText(adapter.Description);
                    this.SetText(String.Empty.PadLeft(adapter.Description.Length, '='));
                }
            }
            label39.Text = "Total No of network Interfaces found : " + count;
            listBox1.Visible = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (nics != null)
            {
                monitoring = true;

                wrkerthread = new Thread(new ThreadStart(this.ThreadProcSafe));
                wrkerthread.Start();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            monitoring = false;
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            int count = 0;
            listBox1.Items.Clear();
            if (nics == null)
            {
                nics = NetworkInterface.GetAllNetworkInterfaces();
            }
            foreach (NetworkInterface adapter in nics)
            {
                if ((adapter.GetIPv4Statistics().BytesReceived > 0) && (!adapter.Description.Contains("Teredo")))
                {
                    count++;
                    this.SetText(adapter.Description);
                    this.SetText(String.Empty.PadLeft(adapter.Description.Length, '='));
                }
            }
            label39.Text = "Total No of network Interfaces found : " + count;
            listBox1.Visible = true;
        }

        private void metroButton2_Click_1(object sender, EventArgs e)
        {
            if (nics != null)
            {
                monitoring = true;

                wrkerthread = new Thread(new ThreadStart(this.ThreadProcSafe));
                wrkerthread.Start();
            }
        }

        private void metroButton2_Click_2(object sender, EventArgs e)
        {
            monitoring = false;
        }
    }
}
