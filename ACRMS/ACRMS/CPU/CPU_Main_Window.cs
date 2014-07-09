using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
        Timer t1;
        Timer t2;
        Timer t3;
        private int count = 0;
        private int value = 0;
        private int index = 0;

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
            t1 = new Timer { Enabled = true, Interval = 1000 };
            t2 = new Timer { Enabled = true, Interval = 1000 };
            t3 = new Timer { Enabled = true, Interval = 1000 };
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
            getHashTable();
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
            //DataRow dr;
            //processTable.Clear();
            foreach (DictionaryEntry item in processSet)
            {
                ArrayList rowItem = (ArrayList)item.Value;
                if (!rowItem[1].ToString().Equals("0"))
                {
                    bool contains = processTable.AsEnumerable().Any(row => rowItem[1].ToString() == row.Field<String>("PID"));
                    if (contains)
                    {
                        var dr = processTable.Select("PID = '" + rowItem[1].ToString() + "'").FirstOrDefault();
                        dr[2] = rowItem[2].ToString();
                    }
                    else
                    {
                        addNewRows(rowItem);
                    }
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
                if (!row[1].ToString().Equals("0")){
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
    }
}
