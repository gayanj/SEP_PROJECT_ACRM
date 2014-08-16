using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACRMS.DISK
{
    using ACRMS.DISK.Smart;

    public partial class SmartDataViewer : Form
    {
        private DataTable smartDataTable;
        public SmartDataViewer()
        {
            InitializeComponent();
        }

        private void btnGetSmart_Click(object sender, EventArgs e)
        {
            WmiDiskSmartData wmiDiskSmartData = new WmiDiskSmartData();
            smartDataTable = wmiDiskSmartData.GetSmartData(Environment.MachineName);
            dgvSmartData.DataSource = smartDataTable;
            dgvSmartData.Refresh();
        }
    }
}
