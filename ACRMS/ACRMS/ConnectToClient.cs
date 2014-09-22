using ACRMS.Websoket;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACRMS
{
    public partial class ConnectToClient : Form
    {
        public static websocket client;
        public ConnectToClient()
        {
            InitializeComponent();
            client = new websocket("localhost","12001");
        }

        private void connect_Client_Click(object sender, EventArgs e)
        {
            client.CreateUniqueSession();
        }
    }
}
