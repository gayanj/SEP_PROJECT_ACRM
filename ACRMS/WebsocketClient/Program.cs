using ACRMS.Websoket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebsocketClient
{
    class Program
    {
        static void Main(string[] args)
        {
            websocket w = new websocket();
            w.CreateUniqueSession();
            Console.ReadLine();
        }
    }
}
