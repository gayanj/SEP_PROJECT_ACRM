using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ACRMS.CPU.CPU_classes
{
    public partial class GraphForm : Form
    {
        string from;
        string to;
        string processName;
        DataTable chartTable;

        public GraphForm(string from, string to, string processName)
        {
            InitializeComponent();
            this.from = from;
            this.to = to;
            this.processName = processName;
            chartTable = new DataTable();
            getChartData();
            setTableChart();
            metroLabel1.Text = processName;
        }

        private void setTableChart()
        {
            //chartTable.Columns.Add("Time", typeof(long));
            //chartTable.Columns.Add("Usage", typeof(int));

            chart1.Series.Add("CPU Usage");
            chart1.Series["CPU Usage"].XValueType = ChartValueType.DateTime;
            chart1.Series["CPU Usage"].ChartType = SeriesChartType.Column;

            chart1.Series["CPU Usage"].XValueMember = "Date Time";
            chart1.Series["CPU Usage"].YValueMembers = "CPU Usage";

            DataRow lastRow = chartTable.Rows[chartTable.Rows.Count - 1];
            DataRow firstRow = chartTable.Rows[0];

            DateTime minDate = Convert.ToDateTime(firstRow[0].ToString());
            DateTime maxDate = Convert.ToDateTime(lastRow[0].ToString());

            TimeSpan dtDiff = maxDate.Subtract(minDate);
            int days = dtDiff.Days;
            int hours = dtDiff.Hours;
            int minutes = dtDiff.Minutes;

            if (days > 1)
            {
                chart1.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Days;

            }
            else if (hours > 1)
            {
                chart1.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Hours;
            }
            else
            {
                chart1.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Minutes;
            }

            chart1.ChartAreas[0].AxisX.Minimum = minDate.ToOADate();
            chart1.ChartAreas[0].AxisX.Maximum = maxDate.ToOADate();

            chart1.ChartAreas[0].AxisY.Maximum = 100;
            chart1.ChartAreas[0].AxisX.Interval = 1;
            chart1.ChartAreas[0].AxisX.IntervalOffset = 1;
            chart1.ChartAreas[0].CursorX.IsUserEnabled = true;
            chart1.ChartAreas[0].CursorX.AutoScroll = true;
            chart1.DataSource = chartTable;
            chart1.DataBind();
        }

        private void getChartData()
        {
            DatabaseFactory.connectToDatabase();
            string query = "select id \"Date Time\",usage \"CPU Usage\" " +
                            "from process_longterm_usage " +
                            "where id >= '" + from + "'  and id < '" + to + "' and name = '" + processName + "' " +
                            "order by id ";
            NpgsqlDataAdapter resultset = DatabaseFactory.executeQuery(query);
            DatabaseFactory.closeConnection();
            resultset.Fill(chartTable);
        }
    }
}
