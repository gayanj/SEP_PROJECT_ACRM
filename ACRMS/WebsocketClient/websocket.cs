using SuperSocket.ClientEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebSocket4Net;
using WebSockets.Data;
using Newtonsoft.Json;

namespace ACRMS.Websoket
{
    public class websocket
    {
        WebSocket webSocket;

        public bool CreateUniqueSession()
        {
            try
            {
                webSocket = new WebSocket("ws://localhost:12001/");
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
            //var value.parameters[0];
            Console.WriteLine(value.response);
        }

        private void websocket_Opened(object sender, EventArgs e)
        {
            Console.WriteLine("Opened!");
            JSONRequest r = new JSONRequest();
            r.request = "getRAMUsage";
            r.parameters = null;
            r.pid = "1";
            webSocket.Send(JsonConvert.SerializeObject(r));
        }

        private void websocket_Error(object sender, EventArgs e)
        {
            Console.WriteLine("Error!");
        }

        private void websocket_Closed(object sender, EventArgs e)
        {
            Console.WriteLine("Closed!");
        }
    }
}
