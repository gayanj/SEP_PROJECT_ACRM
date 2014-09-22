using SuperSocket.ClientEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebSocket4Net;
using WebSockets.Data;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace ACRMS.Websoket
{
    public class websocket
    {
        public delegate void MethodReceivedEventHandler(object sender, MessageReceivedEventArgs e);

        public event MethodReceivedEventHandler CPUData;

        public event MethodReceivedEventHandler DiskData;

        public event MethodReceivedEventHandler RAMData;

        WebSocket webSocket;
        private string ip;
        private string port;

        public websocket(string ip, string port)
        {
            this.ip = ip;
            this.port = port;
        }

        public bool CreateUniqueSession()
        {
            try
            {
                webSocket = new WebSocket("ws://" + ip + ":" + port + "/");
                webSocket.Opened += new EventHandler(websocket_Opened);
                webSocket.Error += new EventHandler<ErrorEventArgs>(websocket_Error);
                webSocket.Closed += new EventHandler(websocket_Closed);
                webSocket.MessageReceived += webSocket_MessageReceived;
                webSocket.Open();
                return true;
            }
            catch (Exception exception)
            {
                return false;
            }
        }

        void webSocket_MessageReceived(object sender, MessageReceivedEventArgs e)
        {
            JSONResponse value = JsonConvert.DeserializeObject<JSONResponse>(e.Message);
            switch (value.response)
            {
                case "startMonitoring":
                    if (CPUData != null)
                        CPUData(this, e);
                    return;
                case "getDISKUsage":
                    if (DiskData != null)
                        DiskData(this, e);
                    return;
                case "getRAMUsage":
                    if (RAMData != null)
                        RAMData(this, e);
                    return;
            }
            //var value.parameters[0];
            //Console.WriteLine(value.response);
        }

        private void websocket_Opened(object sender, EventArgs e)
        {
            //MessageBox.Show("Connected to client!");
        }

        private void websocket_Error(object sender, EventArgs e)
        {
            //MessageBox.Show("Cannot connect to client!");
        }

        private void websocket_Closed(object sender, EventArgs e)
        {
            //MessageBox.Show("Socket Closed!");
        }

        public void getClientData(string request)
        {
            JSONRequest r = new JSONRequest();
            r.request = request;
            r.parameters = null;
            r.pid = "1";
            webSocket.Send(JsonConvert.SerializeObject(r));
        }

        public void closeConnection()
        {
            webSocket.Close();
        }
    }
}
