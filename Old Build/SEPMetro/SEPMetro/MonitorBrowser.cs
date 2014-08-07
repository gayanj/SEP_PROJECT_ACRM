using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SEPMetro.CPU;

namespace SEPMetro
{
    public partial class MonitorBrowser : Form
    {
        public MonitorBrowser()
        {
            InitializeComponent();
            Browsers b = new Browsers();
            metroTextBox1.Text = b.IE();
            //metroTextBox1.Text = b.Chrome();
        }
    }
}
