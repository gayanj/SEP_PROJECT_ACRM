using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SEPMetro
{
    public partial class Configuration : Form
    {
        public static int percentage = 50;
        public static int timeInterval = 5000;
        public static bool checkbox = true;
        public Configuration()
        {
            InitializeComponent();
        }

        private void Configuration_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            percentage = Int32.Parse(ram_alertPercentage.Text);
            timeInterval = Int32.Parse(ram_alertTime.Text);
            if (ram_alertHighMemory.Checked)
                checkbox = true;
            else
                checkbox = false;
            this.Close();
        }
    }
}
