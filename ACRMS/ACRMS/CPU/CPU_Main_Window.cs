using Npgsql;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ACRMS.CPU
{
    public partial class CPU_Main_Window : Form
    {
        DataTable processTable = new DataTable();
        DataTable chartTable;
        Hashtable processSet = new Hashtable();
        ProcessLocal pl = new ProcessLocal();
        System.Windows.Forms.Timer t1;
        System.Windows.Forms.Timer t2;
        System.Windows.Forms.Timer t3;
        private int count = 0;
        private int value = 0;
        private int index = 0;
        int usageLimit = 10;//%
        int waitTime = 60;//seconds
        bool killProcess = false;

        public CPU_Main_Window()
        {
            InitializeComponent();
            processTable.Columns.Add("Process Name");
            processTable.Columns.Add("PID");
            processTable.Columns.Add("CPU Usage");
            processTable.PrimaryKey = new DataColumn[] { processTable.Columns["PID"] };
            chartTable = new DataTable("CPU Usage");
            setTableChart();
            getHashTable();
            setProcessTable();
            dataGridView1.DataSource = processTable;
            t1 = new System.Windows.Forms.Timer { Enabled = true, Interval = 1000 };
            t2 = new System.Windows.Forms.Timer { Enabled = true, Interval = 1000 };
            t3 = new System.Windows.Forms.Timer { Enabled = true, Interval = 1000 };
            t1.Tick += t_Tick_getHashTable;
            t2.Tick += t_Tick_updateDataTable;
            t3.Tick += t_Tick_updateChart;
        }

        private void getHashTable()
        {
            processSet.Clear();
            processSet = pl.ProcessMonitor();
        }

        private void t_Tick_getHashTable(object sender, EventArgs e)
        {
            ThreadPool.QueueUserWorkItem(state => getHashTable());
        }

        private void t_Tick_updateChart(object sender, EventArgs e)
        {
            updateChart();
            count++;
        }

        private void t_Tick_updateDataTable(object sender, EventArgs e)
        {
            updateDataTable();
        }

        private void t_Tick_updateDataGridView(object sender, EventArgs e)
        {
            updateDataGridView();
        }

        private void updateDataTable()
        {
            removeOldRows();
            foreach (DictionaryEntry item in processSet)
            {
                ArrayList rowItem = (ArrayList)item.Value;
                //We dont take Total and Idle PID into account because both have a PID of 0 
                //and this conflicts with the dataTable primary key
                if (!rowItem[1].ToString().Equals("0"))
                {
                    //check if process has exceeded the usage lmit
                    if (Int32.Parse(rowItem[2].ToString()) > usageLimit)
                    {
                        ThreadPool.QueueUserWorkItem(state => trackProcess(rowItem[1].ToString()));
                    }
                    //check if PID exist in the dataTable
                    bool contains = processTable.AsEnumerable().Any(row => rowItem[1].ToString() == row.Field<String>("PID"));
                    if (contains)
                    {
                        //retireve the dataRow containing the PID
                        var dr = processTable.Select("PID = '" + rowItem[1].ToString() + "'").FirstOrDefault();
                        dr[2] = rowItem[2].ToString();
                    }
                    //otherwise add a new row to dataTable with new PID
                    else
                    {
                        addNewRows(rowItem);
                    }
                }
            }
        }

        private void removeOldRows()
        {
            var dr = processTable.Select();
            foreach (DataRow row in dr)
            {
                try
                {
                    //check if the process is still alive
                    Process process = Process.GetProcessById(Int32.Parse(row[1].ToString()));
                }
                catch (ArgumentException e)
                {
                    //remove process from dataTable
                    processTable.Rows.Remove(row);
                    continue;
                }
            }
        }

        private void addNewRows(ArrayList rowItem)
        {
            bool contains = processTable.AsEnumerable().Any(row => rowItem[0].ToString() == row.Field<String>("Process Name"));
            if (contains)
            {
                var drName = processTable.Select("[" + processTable.Columns[0].ColumnName + "] = '" + rowItem[0].ToString() + "'").FirstOrDefault();
                processTable.Rows.Remove(drName);
            }
            DataRow dr = processTable.NewRow();
            dr[0] = rowItem[0].ToString();
            dr[1] = rowItem[1].ToString();
            dr[2] = rowItem[2].ToString();
            processTable.Rows.Add(dr);
        }

        private void setProcessTable()
        {
            DataRow dr;
            foreach (DictionaryEntry item in processSet)
            {
                ArrayList row = (ArrayList)item.Value;
                if (!row[1].ToString().Equals("0"))
                {
                    dr = processTable.NewRow();
                    dr[0] = row[0].ToString();
                    dr[1] = row[1].ToString();
                    dr[2] = row[2].ToString();
                    processTable.Rows.Add(dr);
                }
            }
        }

        private void updateDataGridView()
        {
            int scrollPosition = dataGridView1.FirstDisplayedScrollingRowIndex;
            dataGridView1.DataSource = processTable;
            if (scrollPosition == -1)
            {
                dataGridView1.FirstDisplayedScrollingRowIndex = scrollPosition + 1;
            }
            else
            {
                dataGridView1.FirstDisplayedScrollingRowIndex = scrollPosition;
            }
        }

        private void setTableChart()
        {
            chartTable.Columns.Add("Seconds", typeof(int));
            chartTable.Columns.Add("Value", typeof(float));

            cpuChart.Series.Add("CPU Usage");
            cpuChart.Series["CPU Usage"].ChartType = SeriesChartType.Line;
            cpuChart.Series["CPU Usage"].XValueMember = "Seconds";

            cpuChart.Series["CPU Usage"].YValueMembers = "Value";
            cpuChart.ChartAreas[0].AxisY.Maximum = 100;
            cpuChart.ChartAreas[0].AxisX.Minimum = 0;
            cpuChart.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Seconds;
            cpuChart.ChartAreas[0].CursorX.IsUserEnabled = true;
            cpuChart.ChartAreas[0].CursorX.AutoScroll = true;
            cpuChart.DataSource = chartTable;
            cpuChart.DataBind();
        }

        private void updateChart()
        {
            chartTable.Rows.Add(count, value);
            try
            {
                value = Int32.Parse(dataGridView1[2, index].Value.ToString());
                this.cpuChart.DataBind();
            }
            catch (ArgumentOutOfRangeException ex)
            {
                //Occurs on forced exit
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (var series in cpuChart.Series)
            {
                series.Points.Clear();
            }
            chartTable.Clear();
            count = 0;
            index = dataGridView1.CurrentCell.RowIndex;
            //processName.Visible = true;
            //processNameValue.Visible = true;
            //processNameValue.Text = dataGridView1[1, index].Value.ToString();
            this.changeUsageValue();
        }

        private void changeUsageValue()
        {
            value = Int32.Parse(dataGridView1[2, index].Value.ToString());
        }

        public void trackProcess(string PID)
        {
            int counterTime = waitTime;
            //to do add exception handler
            try
            {
                Process pname = Process.GetProcessById(Int32.Parse(PID));

                while (counterTime >= 0)
                {
                    try
                    {
                        bool contains = processTable.AsEnumerable().Any(row => PID == row.Field<String>("PID"));
                        if (contains)
                        {
                            var dr = processTable.Select("PID = '" + PID + "'").FirstOrDefault();

                            if (Int32.Parse(dr[2].ToString()) > usageLimit)
                            {
                                counterTime--;
                                Thread.Sleep(1000);
                                continue;
                            }
                            else
                            {
                                break;
                            }
                        }
                    }
                    catch (InvalidOperationException e)
                    {
                        break;
                    }
                    catch (RowNotInTableException e)
                    {
                        break;
                    }
                    catch (NullReferenceException e)
                    {
                        break;
                    }
                }

                if (counterTime == 0)
                {
                    //TO DO -- add PID details to database
                    string sql = "INSERT INTO processes(name,duration) VALUES('" + pname.ProcessName + "','" + waitTime + "')";
                    DatabaseFactory.connectToDatabase();
                    int result = DatabaseFactory.executeNonQuery(sql);
                    if (result < 0)
                    {
                        //error inserting
                    }
                    DatabaseFactory.closeConnection();
                    //kill the process automatically if specified by user
                    if (killProcess)
                    {
                        Process p = Process.GetProcessById(Int32.Parse(PID));
                        Process currentP = Process.GetCurrentProcess();
                        if (!(p == currentP || p.ProcessName.Equals("explorer")))
                        {
                            p.Kill();
                        }
                    }
                }
            }
            catch (ArgumentException e)
            {
                //PID removed
            }
            catch (InvalidOperationException e)
            {
                //Process removed
            }
            catch (Win32Exception e)
            {
                //dont kill system processes
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            DataTable processes = new DataTable();
            DatabaseFactory.connectToDatabase();
            string query = "select name \"Name\",duration \"Duration\" from processes where id >= (now() - '1 hour'::INTERVAL)";
            NpgsqlDataAdapter resultset = DatabaseFactory.executeQuery(query);
            DatabaseFactory.closeConnection();
            resultset.Fill(processes);
            dataGridView2.DataSource = processes;
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            DataTable processes = new DataTable();
            DatabaseFactory.connectToDatabase();
            string query = "select name,duration from processes";
            NpgsqlDataAdapter resultset = DatabaseFactory.executeQuery(query);
            DatabaseFactory.closeConnection();
            resultset.Fill(processes);
            dataGridView2.DataSource = processes;
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            DataTable processes = new DataTable();
            DatabaseFactory.connectToDatabase();
            string query = "delete from processes";
            DatabaseFactory.executeNonQuery(query);

            string query2 = "select name,duration from processes";
            NpgsqlDataAdapter resultset = DatabaseFactory.executeQuery(query);

            DatabaseFactory.closeConnection();
            resultset.Fill(processes);
            dataGridView2.DataSource = processes;
        }

        private void setUsage_Click(object sender, EventArgs e)
        {
            usageLimit = Int32.Parse(metroTextBox1.Text.ToString());
        }

        private void setTime_Click(object sender, EventArgs e)
        {
            waitTime = Int32.Parse(metroTextBox2.Text.ToString());
        }

        private void metroCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox1.Checked)
            {
                killProcess = true;
            }
            else
            {
                killProcess = false;
            }
        }
    }
}
