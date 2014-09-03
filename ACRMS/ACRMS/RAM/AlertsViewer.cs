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

namespace ACRMS.RAM
{
    public partial class AlertsViewer : Form
    {
        SqlConnection myConnection;
        System.Windows.Forms.Timer dbTick;
        public AlertsViewer()
        {
            InitializeComponent();
        }

        private void AlertsViewer_Load(object sender, EventArgs e)
        {
       //     dbTick = new System.Windows.Forms.Timer { Enabled = true, Interval = 2000 };
       //     dbTick.Tick += tick_dbTick;

            String connectionString = "Data Source=DELL-PC;Initial Catalog=Monitor;User ID=dell-PC;Password=dell-PC";
            myConnection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand("select * from Alerts",myConnection);

            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = command;
                DataTable table = new DataTable();
                da.Fill(table);
                BindingSource soure = new BindingSource();

                soure.DataSource = table;
                dataGridView1.DataSource = soure;
                da.Update(table);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }

        //void tick_dbTick(object sender, EventArgs e)
        //{
        //    SqlCommand command = new SqlCommand("select * from Alerts", myConnection);

        //    try
        //    {
        //        SqlDataAdapter da = new SqlDataAdapter();
        //        da.SelectCommand = command;
        //        DataTable table = new DataTable();
        //        da.Fill(table);
        //        BindingSource soure = new BindingSource();

        //        soure.DataSource = table;
        //        dataGridView1.DataSource = soure;
        //        da.Update(table);
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex);
        //    }
        //}

        private void metroButton1_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("select * from Alerts", myConnection);

            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = command;
                DataTable table = new DataTable();
                da.Fill(table);
                BindingSource soure = new BindingSource();

                soure.DataSource = table;
                dataGridView1.DataSource = soure;
                da.Update(table);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
