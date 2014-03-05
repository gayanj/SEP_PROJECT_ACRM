using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;

namespace ACRM.CPU
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

        public static ArrayList SystemMonitor(ManagementScope connectionScope,
                                                  string processName)
        {
            ArrayList systemMonitor = new ArrayList();
            SelectQuery systemMonitorQuery = new SelectQuery("SELECT * FROM win32_PerfFormattedData_PerfProc_Process WHERE Name='" + processName + "'");
            ManagementObjectSearcher searchProcedure = new ManagementObjectSearcher(connectionScope, systemMonitorQuery);
            foreach (ManagementObject item in searchProcedure.Get())
            {
                try { systemMonitor.Add("Name: " + item["Name"].ToString()); }
                catch (SystemException) { }
                try { systemMonitor.Add("Process ID: " + item["CreatingProcessID"].ToString()); }
                catch (SystemException) { }
                try { systemMonitor.Add("CPU Usage: " + item["PercentProcessorTime"].ToString()); }
                catch (SystemException) { }
            }
            return systemMonitor;
        }
    }
}
