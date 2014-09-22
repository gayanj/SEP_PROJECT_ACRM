using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RAM;
using ACRMS.Websoket;
using WebSockets.Data;
using System.Collections;
using Newtonsoft.Json;

namespace SEPMetro
{
    public partial class MemoryAnalytics : Form
    {
        websocket w;
        MEMORYSTATUSEX m;
        public MemoryAnalytics()
        {
            InitializeComponent();
            w = new websocket("localhost", "12001");
            w.CreateUniqueSession();
            System.Threading.Thread.Sleep(2000);
            w.RAMData += w_RAMData;
        }

        void w_RAMData(object sender, WebSocket4Net.MessageReceivedEventArgs e)
        {
            JSONResponse value = JsonConvert.DeserializeObject<JSONResponse>(e.Message);
            Hashtable diskData = value.parameters["GetRamUsage"];
            m = JsonConvert.DeserializeObject<MEMORYSTATUSEX>(diskData["ramUsage"].ToString());
        }

        private void ram_RunningApps_Click(object sender, EventArgs e)
        {
            w.getClientData("getRAMUsage");
            ram_analytics.Text = string.Empty;
            if (m != null)
                ram_analytics.Text = ProcessList.ListAllApplications(m);
        }

        private void ram_ViewProcesses_Click(object sender, EventArgs e)
        {
            ram_analytics.Text = string.Empty;
            ram_analytics.Text = ProcessList.ListAllProcesses();
        }

        private void ram_ViewImages_Click(object sender, EventArgs e)
        {
            ram_analytics.Text = string.Empty;
            ram_analytics.Text = ProcessList.ListAllByImageName();
        }

        private void MemoryAnalytics_FormClosed(object sender, FormClosedEventArgs e)
        {
            w.closeConnection();
        }
    }
}
