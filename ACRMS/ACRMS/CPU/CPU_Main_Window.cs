using ACRMS.CPU.CPU_classes;
using Npgsql;
using ServiceStack.Redis;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using VirusTotalNET;
using VirusTotalNET.Objects;

namespace ACRMS.CPU
{
    public partial class CPU_Main_Window : Form
    {
        RedisService redisService;
        VirusTotal virusTotal = new VirusTotal(ConfigurationManager.AppSettings["ApiKey"]);
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
        private int index2 = 0;
        int usageLimit = 10;//%
        int waitTime = 60;//seconds
        int cacheCount = 60;//seconds
        int idCount = 0;
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
            //Use HTTPS instead of HTTP
            virusTotal.UseTLS = true;
            ACRM_MetroMain.load.Close();
            redisService = new RedisService();
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
            if (cacheCount <= 0)
            {
                cacheCount = 60;
                ThreadPool.QueueUserWorkItem(state =>redisService.persistStoredCache());
            }
            //call redis service
            //store in redis cache
            idCount++;
            Hashtable processSetCopy = processSet;
            ThreadPool.QueueUserWorkItem(state =>redisService.storeInCache(processSetCopy, idCount));

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
            cacheCount--;
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

            if (rowItem[0].ToString().IndexOf("chrome#") == -1 
                && rowItem[0].ToString().IndexOf("postgres#") == -1 
                && rowItem[0].ToString().IndexOf("conhost#") == -1 
                && rowItem[0].ToString().IndexOf("SearchFilterHost") == -1
                && rowItem[0].ToString().IndexOf("SearchProtocolHost") == -1)
            {
                string sql = "INSERT INTO process_usage(process_name) VALUES('" + rowItem[0].ToString() + "')";
                DatabaseFactory.connectToDatabase();
                int result = DatabaseFactory.executeNonQuery(sql);
                if (result < 0)
                {
                    //error inserting
                }
                DatabaseFactory.closeConnection();
            }
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
            catch (NullReferenceException ex)
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

                    //scan using virus total
                    virusTotalScan(PID);
                    //add PID details to database
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
            string query = "select name \"Name\",duration \"Duration\" from processes";
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

            string query2 = "select name \"Name\",duration \"Duration\" from processes";
            NpgsqlDataAdapter resultset = DatabaseFactory.executeQuery(query2);

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

        private void virusTotalScan(string PID)
        {
            try
            {
                FileInfo file = new FileInfo("EICAR.txt");
                //File.WriteAllText(file.FullName, @"X5O!P%@AP[4\PZX54(P^)7CC)7}$EICAR-STANDARD-ANTIVIRUS-TEST-FILE!$H+H*");
                File.WriteAllText(file.FullName, @"Hello World");
                Process p = Process.GetProcessById(Int32.Parse(PID));
                string filename = p.MainModule.FileName;

                //Find if the file has been already scanned
                DataTable processes = new DataTable();
                DatabaseFactory.connectToDatabase();
                string query = "select filename from malicious where filename = '" + Path.GetFileName(filename) + "'";
                NpgsqlCommand objCommand = new NpgsqlCommand(query, DatabaseFactory.getCurrentConnection());
                NpgsqlDataReader dr = objCommand.ExecuteReader();
                DatabaseFactory.closeConnection();

                if (!dr.HasRows)
                {
                    byte[] resource;
                    using (var md5 = MD5.Create())
                    {
                        using (var stream = File.OpenRead(filename))
                        {
                            resource = md5.ComputeHash(Encoding.UTF8.GetBytes(stream.ToString()));
                        }
                    }
                    StringBuilder sBuilder = new StringBuilder();

                    // Loop through each byte of the hashed data  
                    // and format each one as a hexadecimal string. 
                    for (int i = 0; i < resource.Length; i++)
                    {
                        sBuilder.Append(resource[i].ToString("x2"));
                    }

                    string r = sBuilder.ToString();
                    Report fileReport = virusTotal.GetFileReport(file);
                    bool hasFileBeenScannedBefore = fileReport.ResponseCode == ReportResponseCode.Present;
                    //If the file has been scanned before, the results are embedded inside the report.
                    if (hasFileBeenScannedBefore)
                    {
                        PrintScan(fileReport, Path.GetFileName(filename));
                    }
                    else
                    {
                        FileInfo fileInfo = new FileInfo(filename);
                        VirusTotalNET.Objects.ScanResult fileResult = virusTotal.ScanFile(fileInfo);
                        PrintScan(fileResult);
                    }
                }
            }
            catch (ArgumentException e)
            {
                //Process removed
            }
            catch (InvalidOperationException e)
            {
                //Process removed
            }
            catch (Win32Exception e)
            {
                //cannot scan system files
            }
        }

        private static void PrintScan(VirusTotalNET.Objects.ScanResult scanResult)
        {
            Console.WriteLine("Scan ID: " + scanResult.ScanId + "\n");
            Console.WriteLine("Message: " + scanResult.VerboseMsg + "\n");
        }

        private static void PrintScan(Report report, string fileName)
        {
            Console.WriteLine("Scan ID: " + report.ScanId + "\n");
            Console.WriteLine("Message: " + report.VerboseMsg + "\n");

            if (report.ResponseCode == ReportResponseCode.Present)
            {
                StringBuilder reportBuilder = new StringBuilder();
                reportBuilder.Append("Scan ID: " + report.ScanId + "\n");
                reportBuilder.Append("Message: " + report.VerboseMsg + "\n");
                bool detected = false;
                foreach (ScanEngine scan in report.Scans)
                {
                    if (scan.Detected)
                    {
                        detected = true;
                    }
                    string line = String.Format("{0,-20}", scan.Name);
                    reportBuilder.Append(line + " Detected: " + scan.Detected + "\n");
                }
                if (detected)
                {
                    string sql = "INSERT INTO malicious(filename,report) VALUES('" + fileName + "','" + reportBuilder.ToString() + "')";
                    DatabaseFactory.connectToDatabase();
                    int result = DatabaseFactory.executeNonQuery(sql);
                    if (result < 0)
                    {
                        //error inserting
                    }
                    DatabaseFactory.closeConnection();
                }
            }
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedRowIndex = dataGridView3.CurrentCell.RowIndex;
                string fileName = dataGridView3[0, index2].Value.ToString();

                DataTable processes = new DataTable();
                DatabaseFactory.connectToDatabase();
                string query = "select report from malicious where filename = '" + fileName + "'";
                NpgsqlDataAdapter resultset = DatabaseFactory.executeQuery(query);
                DatabaseFactory.closeConnection();
                resultset.Fill(processes);
                MessageBox.Show(processes.Rows[0][0].ToString());
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("No reports to display");
            }
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            DataTable processes = new DataTable();
            DatabaseFactory.connectToDatabase();
            string query = "delete from malicious";
            DatabaseFactory.executeNonQuery(query);

            string query2 = "select filename \"File Name\",id \"Time Stamp\" from malicious";
            NpgsqlDataAdapter resultset = DatabaseFactory.executeQuery(query2);

            DatabaseFactory.closeConnection();
            resultset.Fill(processes);
            dataGridView3.DataSource = processes;
        }

        private void metroButton6_Click(object sender, EventArgs e)
        {
            DataTable processes = new DataTable();
            DatabaseFactory.connectToDatabase();
            string query = "select filename \"File Name\",id \"Time Stamp\" from malicious";
            NpgsqlDataAdapter resultset = DatabaseFactory.executeQuery(query);
            DatabaseFactory.closeConnection();
            resultset.Fill(processes);
            dataGridView3.DataSource = processes;
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index2 = dataGridView3.CurrentCell.RowIndex;
        }

        private void metroButton7_Click(object sender, EventArgs e)
        {
            Process[] localByName = Process.GetProcessesByName("iexplore");
            if (localByName.Length == 0)
            {
                MessageBox.Show("Internet Explorer is not running");
            }
            else
            {
                Browser_IE bIE = new Browser_IE();
                bIE.getBroswerInfo();
                dataGridView4.DataSource = bIE.getBrowserTable();
            }
        }

        private void metroButton8_Click(object sender, EventArgs e)
        {
            string host = "localhost";
            string elementKey = "testKeyRedis";

            using (RedisClient redisClient = new RedisClient(host))
            {
                if (redisClient.Get<string>(elementKey) == null)
                {
                    // adding delay to see the difference
                    Thread.Sleep(5000);
                    // save value in cache
                    redisClient.Set(elementKey, "some cached value");
                }
                // get value from the cache by key
                string value = redisClient.Get<string>(elementKey);
                MessageBox.Show("Item value is: " + value);
            }
        }

        private void metroButton9_Click(object sender, EventArgs e)
        {
            DataTable processes = new DataTable();
            DatabaseFactory.connectToDatabase();
            string query = "select process_name \"Name\", count(id) \"Number of Times Used\" " +
                            "from process_usage " +
                            "where id >= (now() - '1 week'::INTERVAL) " +
                            "group by process_name " +
                            "order by count(id) DESC";
            NpgsqlDataAdapter resultset = DatabaseFactory.executeQuery(query);
            DatabaseFactory.closeConnection();
            resultset.Fill(processes);
            dataGridView5.DataSource = processes;
        }

        private void metroButton11_Click(object sender, EventArgs e)
        {
            DataTable processes = new DataTable();
            DatabaseFactory.connectToDatabase();
            string query = "select process_name \"Name\", count(id) \"Number of Times Used\" " +
                            "from process_usage " +
                            "group by process_name " +
                            "order by count(id) DESC";
            NpgsqlDataAdapter resultset = DatabaseFactory.executeQuery(query);
            DatabaseFactory.closeConnection();
            resultset.Fill(processes);
            dataGridView5.DataSource = processes;
        }

        private void metroButton12_Click(object sender, EventArgs e)
        {
            DataTable processes = new DataTable();
            DatabaseFactory.connectToDatabase();
            string query = "select name \"Process Name\", max(usage) \"CPU Usage\" " +
                            "from process_longterm_usage " +
                            "where id >= (now() - '1 week'::INTERVAL) " +
                            "group by usage,name " +
                            "order by usage desc " +
                            "limit 39";
            NpgsqlDataAdapter resultset = DatabaseFactory.executeQuery(query);
            DatabaseFactory.closeConnection();
            resultset.Fill(processes);
            dataGridView6.DataSource = processes;
        }

        private void metroButton13_Click(object sender, EventArgs e)
        {
            DataTable processes = new DataTable();
            DatabaseFactory.connectToDatabase();
            string query = "select name \"Process Name\", max(usage) \"CPU Usage\" " +
                            "from process_longterm_usage " +
                            "where id >= (now() - '1 month'::INTERVAL) " +
                            "group by usage,name " +
                            "order by usage desc " +
                            "limit 39";
            NpgsqlDataAdapter resultset = DatabaseFactory.executeQuery(query);
            DatabaseFactory.closeConnection();
            resultset.Fill(processes);
            dataGridView6.DataSource = processes;
        }

        private void metroButton10_Click(object sender, EventArgs e)
        {
            DataTable processes = new DataTable();
            DatabaseFactory.connectToDatabase();
            string query = "select name \"Process Name\", max(usage) \"CPU Usage\" " +
                            "from process_longterm_usage " +
                            "group by usage,name " +
                            "order by usage desc " +
                            "limit 39";
            NpgsqlDataAdapter resultset = DatabaseFactory.executeQuery(query);
            DatabaseFactory.closeConnection();
            resultset.Fill(processes);
            dataGridView6.DataSource = processes;
        }

        private void metroButton14_Click(object sender, EventArgs e)
        {
            string from = dateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss");
            string to = dateTimePicker2.Value.ToString("yyyy-MM-dd HH:mm:ss");
            index = dataGridView1.CurrentCell.RowIndex;
            string processName = dataGridView1[0, index].Value.ToString();

        }

        private void metroButton15_Click(object sender, EventArgs e)
        {
            string from = dateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss");
            string to = dateTimePicker2.Value.ToString("yyyy-MM-dd HH:mm:ss");

            DataTable processes = new DataTable();
            DatabaseFactory.connectToDatabase();
            string query = "select name \"Process Name\", max(usage) \"CPU Usage\" " +
                            "from process_longterm_usage " +
                            "where id >= '" + from + "'  and id < '" + to + "' " +
                            "group by usage,name " +
                            "order by usage desc " +
                            "limit 39";
            NpgsqlDataAdapter resultset = DatabaseFactory.executeQuery(query);
            DatabaseFactory.closeConnection();
            resultset.Fill(processes);
            dataGridView6.DataSource = processes;
        }
    }
}
