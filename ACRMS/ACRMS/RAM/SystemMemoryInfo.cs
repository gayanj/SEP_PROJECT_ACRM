using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ACRMS;
using RAM;

namespace SEPMetro
{
    public partial class SystemMemoryInfo : Form
    {
        public static string ramPercentageAlert;
        System.Windows.Forms.Timer tick2;
        MEMORYSTATUSEX statusEx;
        SqlConnection myConnection;
        String val1, val2, val3, val4, val5, val6, val7;

        public SystemMemoryInfo()
        {
            InitializeComponent();

            String connectionString = "Data Source=DELL-PC\\MSSQLSERVER2014;Initial Catalog=RAMDataWareHouse;Integrated Security=True";
            myConnection = new SqlConnection(connectionString);

            //tick2 = new System.Windows.Forms.Timer { Enabled = true, Interval = Settings.ramAlertTime };
            //tick2.Tick += tick_Tick2;
        }

        private void SystemMemoryInfo_Load(object sender, EventArgs e)
        {


            statusEx = new MEMORYSTATUSEX();
            statusEx.setValues();
            ram_percentage.Text = statusEx.dwMemoryLoad.ToString();
            ram_totalPhysical.Text = statusEx.convertToBytes(statusEx.ullTotalPhys).ToString("0.00" + " MB");
            ram_availPhysical.Text = statusEx.convertToBytes(statusEx.ullAvailPhys).ToString("0.00" + " MB");
            ram_totalPage.Text = statusEx.convertToBytes(statusEx.ullTotalPageFile).ToString("0.00" + " MB");
            ram_availPage.Text = statusEx.convertToBytes(statusEx.ullAvailPageFile).ToString("0.00" + " MB");
            ram_totalVirtual.Text = statusEx.convertToBytes(statusEx.ullTotalVirtual).ToString("0.00" + " MB");
            ram_availVirtual.Text = statusEx.convertToBytes(statusEx.ullAvailVirtual).ToString("0.00" + " MB");




        }

        void tick_Tick2(object sender, EventArgs e)
        {
            statusEx = new MEMORYSTATUSEX();
            statusEx.setValues();
            val1 = statusEx.dwMemoryLoad.ToString();
            val2 = statusEx.convertToBytes(statusEx.ullTotalPhys).ToString("0.00");
            val3 = statusEx.convertToBytes(statusEx.ullAvailPhys).ToString("0.00");
            val4 = statusEx.convertToBytes(statusEx.ullTotalPageFile).ToString("0.00");
            val5 = statusEx.convertToBytes(statusEx.ullAvailPageFile).ToString("0.00");
            val6 = statusEx.convertToBytes(statusEx.ullTotalVirtual).ToString("0.00");
            val7 = statusEx.convertToBytes(statusEx.ullAvailVirtual).ToString("0.00");

            try
            {
                myConnection.Open();
                string query = "INSERT INTO SystemMemoryInfo(AgentID,PercentageOfMemoryInUse,TotalPhysicalMemory,TotalAvailablePhysicalMemory,CurrentCommittedMemory,MaxAmountCommittableMemory,TotalVirtualMemory,VirtualMemoryAvailable)" + "VALUES(1,'" + val1 + "','" + val2 + "','" + val3 + "','" + val4 + "','" + val5 + "','" + val6 + "','" + val7 + "')";
                SqlCommand insertQuery = new SqlCommand(query, myConnection);
                insertQuery.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("cannot open SQL connection " + ex);
            }
            myConnection.Close();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            MemoryAnalytics m = new MemoryAnalytics();
            m.ShowDialog();
        }
    }
}
