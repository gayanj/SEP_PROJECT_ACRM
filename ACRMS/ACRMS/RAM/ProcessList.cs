using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Management;
using System.Diagnostics;

namespace RAM
{
    public class ProcessList
    {
        private static double[] maxMemoryConsum;
        private static string[] maxMemoryConsumApp;
        public static double maxMemory;
        public static string maxMemoryApp;
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
                        sb.Append("Memory Allocation:\t" +m.convertToBytes((ulong)p.PrivateMemorySize64).ToString()+" MB" + Environment.NewLine);
                        sb.Append(Environment.NewLine);
                        maxMemoryConsum[count] = m.convertToBytes((ulong)p.PrivateMemorySize64);
                        maxMemoryConsumApp[count] = p.MainWindowTitle.ToString();
                        
                        
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
