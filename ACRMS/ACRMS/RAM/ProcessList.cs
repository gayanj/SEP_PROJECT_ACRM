using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Management;
using System.Diagnostics;
using System.Data.SqlClient;
using ACRMS;

namespace RAM
{
    public class ProcessList
    {
        public static string appMemoryAlert;
        public static string processExistAlert;
        private static double[] maxMemoryConsum;
        private static string[] maxMemoryConsumApp;
        public static double maxMemory;
        public static string maxMemoryApp;
        public static string[] app;
        public static string[] process;
        SqlConnection myConnection;
        System.Windows.Forms.Timer tick2;

        public ProcessList()
        {
            String connectionString = "Data Source=DELL-PC;Initial Catalog=Monitor;User ID=dell-PC;Password=dell-PC";
            myConnection = new SqlConnection(connectionString);
            //tick2 = new System.Windows.Forms.Timer { Enabled = true, Interval = Settings.runningAppTime };
            //tick2.Tick += tick_Tick2;
        }

        void tick_Tick2(object sender, EventArgs e)
        {
            if (CheckForProcessByName(Settings.processExists))
            {
                processExistAlert = Settings.processExists + " is running.";

                if (Settings.killProcess)
                {
                    Process[] p = Process.GetProcessesByName(Settings.processExists);
                    Process p2 = p[0];
                    p2.Kill();

                }

                try
                {
                    myConnection.Open();
                    string query2 = "INSERT INTO Alerts(AgentID,dTime,message)" + "VALUES(1,'" + DateTime.Now.ToString() + "','" + processExistAlert + "')";

                    SqlCommand insertQuery = new SqlCommand(query2, myConnection);
                    insertQuery.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("cannot open SQL connection " + ex);
                }
                myConnection.Close();

            }

            Console.WriteLine(processExistAlert);

            StringBuilder sb = new StringBuilder();
            ManagementClass mc = new ManagementClass("Win32_Process");
            try
            {
                myConnection.Open();

            }
            catch (Exception ex)
            {
                Console.WriteLine("cannot open SQL connection " + ex);
            }

            foreach (ManagementObject mo in mc.GetInstances())
            {

                try
                {
                    string query = "INSERT INTO RunningProcesses(AgentID,ProcessName,PID,description)" + "VALUES(1,'" + mo["Name"].ToString() + "','" + mo["ProcessId"].ToString() + "','" + mo["Description"] + "')";
                 
                    SqlCommand insertQuery = new SqlCommand(query, myConnection);
                    insertQuery.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("cannot open SQL connection " + ex);
                }

            }

            MEMORYSTATUSEX m = new MEMORYSTATUSEX();
            StringBuilder sb2 = new StringBuilder();
            foreach (Process p in Process.GetProcesses("."))
            {
                try
                {
                    if (p.MainWindowTitle.Length > 0)
                    {
                        sb.Append("Window Title:\t" + p.MainWindowTitle.ToString() + Environment.NewLine);
                        sb.Append("Process Name:\t" + p.ProcessName.ToString() + Environment.NewLine);
                        sb.Append("Window Handle:\t" + p.MainWindowHandle.ToString() + Environment.NewLine); //context specific unique identifier of a process title window
                        sb.Append("Memory Allocation:\t" + m.convertToBytes((ulong)p.PrivateMemorySize64).ToString() + " MB" + Environment.NewLine);

                        Double x = Double.Parse(m.convertToBytes((ulong)p.PrivateMemorySize64).ToString().Trim());

                        if (x > Convert.ToDouble(Settings.runningApplicationThreshold))
                        {
                            appMemoryAlert = p.MainWindowTitle.ToString() + " has exceeded" + Settings.runningApplicationThreshold + ". Current value is " + m.convertToBytes((ulong)p.PrivateMemorySize64).ToString();

                            string query2 = "INSERT INTO Alerts(AgentID,dTime,message)" + "VALUES(1,'" + DateTime.Now.ToString() + "','" + appMemoryAlert + "')";
                            SqlCommand insertQuery = new SqlCommand(query2, myConnection);
                            insertQuery.ExecuteNonQuery();
                        }
                        Console.WriteLine(appMemoryAlert);

                        try
                        {
                            string query = "INSERT INTO RunningApplications(AgentID,WindowTitle,ProcessName,WindowHandle,MemoryAllocation)" + "VALUES(1,'" + p.MainWindowTitle.ToString() + "','" + p.ProcessName.ToString() + "','" + p.MainWindowHandle.ToString() + "','" + m.convertToBytes((ulong)p.PrivateMemorySize64).ToString() + "')";
                           
                            SqlCommand insertQuery = new SqlCommand(query, myConnection);
                            insertQuery.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("cannot open SQL connection " + ex);
                        }


                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }

            myConnection.Close();
        }

        public static string ListAllProcesses()
        {

            StringBuilder sb = new StringBuilder();
            ManagementClass mc = new ManagementClass("Win32_Process");
            foreach (ManagementObject mo in mc.GetInstances())
            {

                sb.Append("Name:\t" + mo["Name"] + Environment.NewLine);
                sb.Append("ID:\t" + mo["ProcessId"] + Environment.NewLine);
                sb.Append("Description:\t" + mo["Description"] + Environment.NewLine);
                sb.Append(Environment.NewLine);

            }
            return sb.ToString();
        }

        public static string ListAllApplications(MEMORYSTATUSEX m)
        {
            StringBuilder sb = new StringBuilder();
            maxMemoryConsum = new double[1000];
            maxMemoryConsumApp = new string[1000];
            app = new string[1000];
            int maxIndex;
            int count = 0;
            foreach (Process p in Process.GetProcesses(".")) //Creates a new Process component for each process resource on the specified computer.
            {
                try
                {
                    if (p.MainWindowTitle.Length > 0)
                    {
                        sb.Append("Window Title:\t" + p.MainWindowTitle.ToString() + Environment.NewLine);
                        sb.Append("Process Name:\t" + p.ProcessName.ToString() + Environment.NewLine);
                        sb.Append("Window Handle:\t" + p.MainWindowHandle.ToString() + Environment.NewLine); //context specific unique identifier of a process title window
                        sb.Append("Memory Allocation:\t" + m.convertToBytes((ulong)p.PrivateMemorySize64).ToString() + " MB" + Environment.NewLine);
                        sb.Append(Environment.NewLine);
                        maxMemoryConsum[count] = m.convertToBytes((ulong)p.PrivateMemorySize64);
                        maxMemoryConsumApp[count] = p.MainWindowTitle.ToString();

                        app[0] = p.MainWindowTitle.ToString();
                        app[1] = p.ProcessName.ToString();
                        app[2] = p.MainWindowTitle.ToString();
                        app[3] = m.convertToBytes((ulong)p.PrivateMemorySize64).ToString();

                        count++;
                    }
                }
                catch
                {
                }
            }
            maxMemory = maxMemoryConsum.Max();
            maxIndex = maxMemoryConsum.ToList().IndexOf(maxMemory);
            maxMemoryApp = maxMemoryConsumApp[maxIndex];
            return sb.ToString();
        }

        public static string ListAllByImageName()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Process p in Process.GetProcesses(".")) //represents a dll or exe that is loaded into process
            {
                try
                {
                    foreach (ProcessModule pm in p.Modules)
                    {
                        sb.Append("Image Name:\t" + pm.ModuleName.ToString() + Environment.NewLine);
                        //  sb.Append("File Path:\t\t" + pm.FileName.ToString() + Environment.NewLine);
                        sb.Append("Memory Size:\t" + pm.ModuleMemorySize.ToString() + Environment.NewLine);
                        sb.Append("File Path:\t\t" + pm.FileName.ToString() + Environment.NewLine);
                        sb.Append("Internal Name:\t" + pm.FileVersionInfo.InternalName.ToString() + Environment.NewLine);
                        sb.Append("Original File Name:\t" + pm.FileVersionInfo.OriginalFilename.ToString() + Environment.NewLine);
                        sb.Append("File Version:\t" + pm.FileVersionInfo.FileVersion.ToString() + Environment.NewLine);
                        sb.Append("File Description:\t" + pm.FileVersionInfo.FileDescription.ToString() + Environment.NewLine);
                        sb.Append("Product:\t\t" + pm.FileVersionInfo.ProductName.ToString() + Environment.NewLine);
                        sb.Append("Debug:\t\t" + pm.FileVersionInfo.IsDebug.ToString() + Environment.NewLine);
                        sb.Append("Patched:\t\t" + pm.FileVersionInfo.IsPatched.ToString() + Environment.NewLine);
                        sb.Append("Pre-Release:\t" + pm.FileVersionInfo.IsPreRelease.ToString() + Environment.NewLine);
                        sb.Append("Private Build:\t" + pm.FileVersionInfo.PrivateBuild.ToString() + Environment.NewLine);
                        sb.Append("Special Build:\t" + pm.FileVersionInfo.SpecialBuild.ToString() + Environment.NewLine);
                        sb.Append("Language:\t" + pm.FileVersionInfo.Language.ToString() + Environment.NewLine);
                        //sb.Append(pm.FileVersionInfo.ToString() + Environment.NewLine);
                        sb.Append(Environment.NewLine);
                    }
                }
                catch
                {
                }
            }
            return sb.ToString();
        }

        public static bool CheckForProcessByName(string ProcessName)
        {
            ManagementClass mc = new ManagementClass("Win32_Process");
            bool val = false;

            foreach (ManagementObject mo in mc.GetInstances())
            {
                if (mo["Name"].ToString().ToLower() == ProcessName.ToLower())
                {
                    val = true;
                }
            }
            return val;
        }

        public static bool CheckForProcessImageByName(string processImageName)
        {
            bool val = false;

            foreach (Process p in Process.GetProcesses("."))
            {
                try
                {
                    foreach (ProcessModule pm in p.Modules)
                    {
                        if (pm.ModuleName.ToLower() == processImageName.ToLower())
                            val = true;
                    }
                }
                catch
                {
                }

            }
            return val;
        }

        public static bool CheckForApplicationByName(String AppName)
        {
            bool val = false;

            foreach (Process p in Process.GetProcesses("."))
            {
                try
                {
                    if (p.ProcessName.ToString().ToLower() == AppName.ToLower())
                    {
                        val = true;
                    }
                }
                catch
                {
                }
            }
            return val;
        }

        public static bool FindProcessById(string processId)
        {
            ManagementClass mc = new ManagementClass("Win32_Process");
            bool val = false;

            foreach (ManagementObject mo in mc.GetInstances())
            {
                if (mo["ProcessId"].ToString() == processId)
                {
                    val = true;
                }
            }
            return val;
        }


    }
}
