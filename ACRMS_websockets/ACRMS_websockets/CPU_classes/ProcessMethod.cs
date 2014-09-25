using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Management;
using System.Text;
using ACRMS;
using System.Diagnostics;

namespace ACRMS.CPU
{
    class ProcessMethod
    {
        public static string StartProcess(string machineName, string processPath)
        {
            ManagementClass processTask = new ManagementClass(@"\\" + machineName + @"\root\CIMV2",
                                                                            "Win32_Process", null);
            ManagementBaseObject methodParams = processTask.GetMethodParameters("Create");
            methodParams["CommandLine"] = processPath;
            ManagementBaseObject exitCode = processTask.InvokeMethod("Create", methodParams, null);
            return ProcessMethod.TranslateProcessStartExitCode(exitCode["ReturnValue"].ToString());
        }

        public static void KillProcess(ManagementScope connectionScope, string processName)
        {
            SelectQuery msQuery = new SelectQuery("SELECT * FROM Win32_Process Where Name = '" + processName + "'");
            ManagementObjectSearcher searchProcedure = new ManagementObjectSearcher(connectionScope, msQuery);
            foreach (ManagementObject item in searchProcedure.Get())
            {
                try
                {
                    item.InvokeMethod("Terminate", null);
                }
                catch (SystemException e)
                {
                    Console.WriteLine("An Error Occurred: " + e.Message.ToString());
                }
            }
        }

        public static void ChangePriority(ManagementScope connectionScope,
                                          string processName,
                                          ProcessPriority.priority priority)
        {
            SelectQuery msQuery = new SelectQuery("SELECT * FROM Win32_Process Where Name = '" + processName + "'");
            ManagementObjectSearcher searchProcedure = new ManagementObjectSearcher(connectionScope, msQuery);
            foreach (ManagementObject item in searchProcedure.Get())
            {
                try
                {
                    ManagementBaseObject methodParams = item.GetMethodParameters("SetPriority");
                    methodParams["Priority"] = priority;
                    item.InvokeMethod("SetPriority", methodParams, null);
                }
                catch (SystemException e)
                {
                    Console.WriteLine("An Error Occurred: " + e.Message.ToString());
                }
            }
        }

        public static string ProcessOwner(ManagementScope connectionScope,
                                          string processName)
        {
            SelectQuery msQuery = new SelectQuery("SELECT * FROM Win32_Process Where Name = '" + processName + "'");
            ManagementObjectSearcher searchProcedure = new ManagementObjectSearcher(connectionScope, msQuery);
            string owner = string.Empty;
            foreach (ManagementObject item in searchProcedure.Get())
            {
                try
                {
                    ManagementBaseObject methodParams = item.GetMethodParameters("GetOwner");
                    ManagementBaseObject Owner = item.InvokeMethod("GetOwner", null, null);
                    owner = Owner["User"].ToString();
                }
                catch (SystemException e)
                {
                    Console.WriteLine("An Error Occurred: " + e.Message.ToString());
                }
            }
            return owner;
        }

        public static string ProcessOwnerSID(ManagementScope connectionScope,
                                             string processName)
        {
            SelectQuery msQuery = new SelectQuery("SELECT * FROM Win32_Process Where Name = '" + processName + "'");
            ManagementObjectSearcher searchProcedure = new ManagementObjectSearcher(connectionScope, msQuery);
            string owner = string.Empty;
            foreach (ManagementObject item in searchProcedure.Get())
            {
                try
                {
                    ManagementBaseObject methodParams = item.GetMethodParameters("GetOwnerSid");
                    ManagementBaseObject Owner = item.InvokeMethod("GetOwnerSid", null, null);
                    owner = Owner["Sid"].ToString();
                }
                catch (SystemException e)
                {
                    Console.WriteLine("An Error Occurred: " + e.Message.ToString());
                }
            }
            return owner;
        }

        /// <summary>
        /// This method get the list of all the current processes running in the machine
        /// </summary>
        /// <param name="connectionScope">Scope of the connection</param>
        /// <returns>Returns an ArrayList of the current processes</returns>
        public static ArrayList RunningProcesses(ManagementScope connectionScope)
        {
            ArrayList alProcesses = new ArrayList();
            SelectQuery msQuery = new SelectQuery("SELECT * FROM win32_PerfFormattedData_PerfProc_Process");
            ManagementObjectSearcher searchProcedure = new ManagementObjectSearcher(connectionScope, msQuery);

            foreach (ManagementObject item in searchProcedure.Get())
            {
                alProcesses.Add(item["Name"].ToString());
            }

            return alProcesses;
        }
        public static string TranslateMemoryUsage(string workingSet)
        {
            int calc = Convert.ToInt32(workingSet);
            calc = calc / 1024;
            return calc.ToString();
        }
        public static string TranslateProcessStartExitCode(string exitCode)
        {
            string code = string.Empty;
            int eCode = Convert.ToInt32(exitCode);
            switch (eCode)
            {
                case 0: code = "Successful(Completion)";
                    break;
                case 2: code = "Access(Denied)";
                    break;
                case 3: code = "Insufficient(priviledge)";
                    break;
                case 8: code = "Uknown(Failure)";
                    break;
                case 9: code = "Path(Not Found)";
                    break;
                case 21: code = "Invalid(Parameter)";
                    break;
            }
            return code;
        }


        /// <summary>
        /// This method is used to retrieve information about a particular process
        /// </summary>
        /// <param name="connectionScope">Scope of the connection - Defines the scope in which the methods are being called</param>
        /// <returns>Returns an ArrayList of the processes information</returns>
        public static Hashtable SystemMonitor(ManagementScope connectionScope)
        {
            Hashtable processes = new Hashtable();
            ArrayList arrprocesses;
            SelectQuery systemMonitorQuery = new SelectQuery("SELECT Name,IDProcess,PercentProcessorTime FROM win32_PerfFormattedData_PerfProc_Process");
            ManagementObjectSearcher searchProcedure = new ManagementObjectSearcher(connectionScope, systemMonitorQuery);
            foreach (ManagementObject item in searchProcedure.Get())
            {
                arrprocesses = new ArrayList();
                arrprocesses.Add(item.Properties["Name"].Value);
                arrprocesses.Add(item.Properties["IDProcess"].Value);
                arrprocesses.Add(item.Properties["PercentProcessorTime"].Value);

                processes.Add(item["Name"].ToString(), arrprocesses);
                item.Dispose();
            }
            searchProcedure.Dispose();
            return processes;
        }

        public static int GetCpuUsage(ManagementScope connectionScope)
        {
            SelectQuery systemMonitorQuery = new SelectQuery("SELECT * FROM Win32_PerfFormattedData_PerfOS_Processor WHERE Name=\"_Total\"");
            ManagementObjectSearcher searcher =
                    new ManagementObjectSearcher(connectionScope, systemMonitorQuery);
            foreach (ManagementObject queryObj in searcher.Get())
            {
                return Int32.Parse(queryObj["PercentProcessorTime"].ToString());
            }
            return -1;
        }

        /// <summary>
        /// This method is used to retrieve information about a particular process
        /// </summary>
        /// <param name="connectionScope">Scope of the connection - Defines the scope in which the methods are being called</param>
        /// <returns>Returns an ArrayList of the processes information</returns>
        public static Hashtable PersistantMonitor(ManagementScope connectionScope)
        {
            Hashtable processes = new Hashtable();
            ArrayList arrprocesses;
            SelectQuery systemMonitorQuery = new SelectQuery(
            "SELECT Name,CreatingProcessID,ElapsedTime,HandleCount,IDProcess,PercentProcessorTime," +
            "PercentUserTime,ThreadCount FROM win32_PerfFormattedData_PerfProc_Process");
            ManagementObjectSearcher searchProcedure = new ManagementObjectSearcher(connectionScope, systemMonitorQuery);
            foreach (ManagementObject item in searchProcedure.Get())
            {
                arrprocesses = new ArrayList();
                arrprocesses.Add(GetDatestamp(DateTime.Now));
                arrprocesses.Add(GetTimestamp(DateTime.Now));
                arrprocesses.Add(item.Properties["Name"].Value);
                arrprocesses.Add(item.Properties["CreatingProcessID"].Value);
                arrprocesses.Add(item.Properties["ElapsedTime"].Value);
                arrprocesses.Add(item.Properties["HandleCount"].Value);
                arrprocesses.Add(item.Properties["IDProcess"].Value);
                arrprocesses.Add(item.Properties["PercentProcessorTime"].Value);
                arrprocesses.Add(item.Properties["PercentUserTime"].Value);
                arrprocesses.Add(item.Properties["ThreadCount"].Value);

                processes.Add(item["Name"].ToString(), arrprocesses);

                item.Dispose();
            }
            searchProcedure.Dispose();
            return processes;
        }

        public static String GetDatestamp(DateTime value)
        {
            return value.ToString("yyyyMMdd");
        }

        public static String GetTimestamp(DateTime value)
        {
            TimeSpan ts = TimeSpan.Parse(value.ToString("HH:mm:ss"));
            return ts.TotalSeconds.ToString();
        }

        /// <summary>
        /// This method is used to retrieve information about a particular process
        /// </summary>
        /// <param name="connectionScope">Scope of the connection - Defines the scope in which the methods are being called</param>
        /// <returns>Returns an ArrayList of the processes information</returns>
        public static Hashtable GetTrackProcessData(ManagementScope connectionScope)
        {
            Hashtable processes = new Hashtable();
            ArrayList arrprocesses;
            SelectQuery systemMonitorQuery = new SelectQuery(
                "SELECT Name,IDProcess,PercentProcessorTime FROM win32_PerfFormattedData_PerfProc_Process");
            ManagementObjectSearcher searchProcedure = new ManagementObjectSearcher(connectionScope, systemMonitorQuery);
            foreach (ManagementObject item in searchProcedure.Get())
            {
                arrprocesses = new ArrayList();
                arrprocesses.Add(item.Properties["Name"].Value);
                arrprocesses.Add(item.Properties["IDProcess"].Value);
                arrprocesses.Add(item.Properties["PercentProcessorTime"].Value);
                processes.Add(item["Name"].ToString(), arrprocesses);

                item.Dispose();
            }
            searchProcedure.Dispose();
            return processes;
        }

        public static float GetProcessData(ManagementScope connectionScope, string pname)
        {
            //        PerformanceCounter processorTimeCounter = new PerformanceCounter(
            //            "Process",
            //            "% Processor Time",
            //            pname);
            //        processorTimeCounter.NextValue();

            //System.Threading.Thread.Sleep(1000);

            //float usage = 0;
            //usage = processorTimeCounter.NextValue();

            //return usage;
            try
            {
                PerformanceCounter cpuUsage = new PerformanceCounter("Process", "% Processor Time", "_Total");
                PerformanceCounter pcProcess = new PerformanceCounter("Process", "% Processor Time", pname);
                // Prime the Performance Counters
                pcProcess.NextValue();
                cpuUsage.NextValue();
                System.Threading.Thread.Sleep(100);

                double cpuUse = Math.Round(pcProcess.NextValue() / cpuUsage.NextValue() * 100, 2);

                // Check for Not-A-Number (Division by Zero)
                if (Double.IsNaN(cpuUse))
                    cpuUse = 0;

                //Get CPU Usage
                Console.ForegroundColor = ConsoleColor.Red;
                return Convert.ToInt32(cpuUse);
            }
            catch (Exception e)
            {
                return 0;
            }
        }
    }
}
