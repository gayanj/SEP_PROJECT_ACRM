using System;
using System.Windows.Forms;
using ACRMS.DISK;

using SEPMetro;

namespace ACRMS
{
    public partial class ACRM_MetroMain : Form
    {
        public static CPU.loadingForm load;
        public ACRM_MetroMain()
        {
            InitializeComponent();

            // this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            // WindowState = FormWindowState.Maximized;
        }
         
        private void metroTile1_Click(object sender, EventArgs e)
        {
            SEPMetro.RAM r = new SEPMetro.RAM();
            r.ShowDialog();
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            load = new CPU.loadingForm();
            load.Show();
            
            CPU.CPU_Main_Window c = new CPU.CPU_Main_Window();
            c.ShowDialog();
        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            BatteryForm b = new BatteryForm();
            b.ShowDialog();
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            DiskMainGUI d = new DiskMainGUI();
            d.ShowDialog();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            NetworkCore n = new NetworkCore();
            n.ShowDialog();
        }
    }
}
