using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ACRM.RAM;
using ACRMS;

namespace SEPMetro
{
    public partial class IdleCheckForm : Form
    {
        public static string alertMessageGuiActivity;
        public static String alertMessageidleState;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer tick2;
        private long idleCounter = 0;
        SqlConnection myConnection;
        string idleDuration;
        public IdleCheckForm()
        {
            InitializeComponent();

            String connectionString = "Data Source=DELL-PC\\MSSQLSERVER2014;Initial Catalog=RAMDataWareHouse;Integrated Security=True";
            myConnection = new SqlConnection(connectionString);

            int cpuPct = (int)(ApplicationIdleTimer.CPUUsageThreshold * 100.0);

            this.ram_adjThreshold.Value = (int)ApplicationIdleTimer.GUIActivityThreshold;
            this.ram_guiThreshold.Text = this.ram_adjThreshold.Value.ToString("#0.0");

            // Listen for changes
            //  this.ram_adjThreshold.Scroll += new System.EventHandler(this.adjGUIThreshold_Scroll);
            this.ram_adjThreshold.Scroll += new ScrollEventHandler(this.adjGUIThreshold_Scroll);


            // Hook into the ApplicationIdle event
            ApplicationIdleTimer.ApplicationIdle += new ApplicationIdleTimer.ApplicationIdleEventHandler(this.App_Idle);

            // Also hook into the Application.Idle event, for comparison

            // Start the timer
            timer1 = new System.Windows.Forms.Timer();
            timer1.Interval = 250;
            timer1.Tick += new System.EventHandler(this.timer1_Tick);
            timer1.Start();
             //tick2 = new System.Windows.Forms.Timer { Enabled = true, Interval =Settings.idleCheckerTime };
             //tick2.Tick += tick_Tick2;
           // inputDataWareHouse();
        }

        public void inputDataWareHouse()
        {
            SqlCommand cmd = new SqlCommand("SELECT DateKey from DimDate", myConnection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                for (int j = 0; j < 8639; j = j + 60)
                {
                    if (!ApplicationIdleTimer.IsIdle && this.ram_status.Text != "Busy")
                    {
                        this.ram_status.BackColor = Color.Red;
                        this.ram_status.Text = "Busy";
                    }


                    try
                    {
                        myConnection.Open();
                        string query = "INSERT INTO FactIdleChecker(AgentID,GuiActivity,AppIdleEvents,IdleState,DateKey,TimeKey)" + "VALUES(1,'" + ApplicationIdleTimer.CurrentGUIActivity.ToString("#0.0") + "','" + idleCounter.ToString("#,##0") + "','" + ram_status.Text + Int32.Parse(dr["DateKey"].ToString()) + "','" + j + "')";
                        
                        SqlCommand insertQuery = new SqlCommand(query, myConnection);
                        insertQuery.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("cannot open SQL connection " + ex);
                    }
                    myConnection.Close();
                    Thread.Sleep(60000);
                }

            }
        }

        void tick_Tick2(object sender, EventArgs e)
        {
            if (!ApplicationIdleTimer.IsIdle && this.ram_status.Text != "Busy")
            {
                this.ram_status.BackColor = Color.Red;
                this.ram_status.Text = "Busy";
            }

            Double x = Double.Parse(ApplicationIdleTimer.CurrentGUIActivity.ToString("#0.0").Trim());

            Console.WriteLine(alertMessageGuiActivity + Environment.NewLine + alertMessageidleState);

            try
            {
                myConnection.Open();
                string query = "INSERT INTO IdleChecker(AgentID,GuiActivity,AppIdleEvents,IdleState)" + "VALUES(1,'" + ApplicationIdleTimer.CurrentGUIActivity.ToString("#0.0") + "','" + idleCounter.ToString("#,##0") + "','" + ram_status.Text + "')";
       
                SqlCommand insertQuery = new SqlCommand(query, myConnection);
                insertQuery.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("cannot open SQL connection " + ex);
            }
            myConnection.Close();
        }

        private void IdleCheckForm_Load(object sender, EventArgs e)
        {

        }

        private void App_Idle(ApplicationIdleTimer.ApplicationIdleEventArgs e)
        {
            this.ram_status.BackColor = Color.Green;
            this.ram_status.Text = string.Format("Idle: {0}s", e.IdleDuration.TotalSeconds.ToString("0"));
            idleDuration = e.IdleDuration.TotalSeconds.ToString("0");
        }

        private void Idle_Count(object sender, System.EventArgs e)
        {
            idleCounter++;
        }

        private void adjGUIThreshold_Scroll(object sender, System.EventArgs e)
        {
            double val = (double)this.ram_adjThreshold.Value;
            this.ram_guiThreshold.Text = val.ToString("#0.0");
            ApplicationIdleTimer.GUIActivityThreshold = val;
        }

        private void timer1_Tick(object sender, System.EventArgs e)
        {
            if (!ApplicationIdleTimer.IsIdle && this.ram_status.Text != "Busy")
            {
                this.ram_status.BackColor = Color.Red;
                this.ram_status.Text = "Busy";
            }

            this.ram_guiActivity.Text = ApplicationIdleTimer.CurrentGUIActivity.ToString("#0.0");
            this.ram_appIdleEvents.Text = idleCounter.ToString("#,##0");

        }
    }
}
