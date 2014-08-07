using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACRMS.CPU.CPU_classes
{
    class Browser_IE
    {
        static uint processID;
        ConnectionOptions options;
        ManagementScope connectionScope;
        DataTable browserTable = new DataTable();

        public Browser_IE()
        {
            options = ProcessConnection.ProcessConnectionOptions();
            connectionScope = ProcessConnection.ConnectionScope(
                                     Environment.MachineName, options);
            browserTable.Columns.Add("PID");
            browserTable.Columns.Add("Tab Title");
            browserTable.Columns.Add("CPU Usage");
        }

        [DllImport("user32.dll", SetLastError = true)]
        public static extern uint GetWindowThreadProcessId(IntPtr hWnd, out uint lpdwProcessId);

        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        static extern int GetWindowTextLength(IntPtr hWnd);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        static extern int GetWindowText(IntPtr hWnd, StringBuilder lpString, int nMaxCount);

        [DllImport("user32.dll")]
        static extern IntPtr GetTopWindow(IntPtr hWnd);

        public void getBroswerInfo()
        {
            int j = 0;
            Process[] localByName = Process.GetProcessesByName("iexplore");
            int[] PID = new int[localByName.Length - 1];
            for (int i = 0; i < localByName.Length; i++)
            {
                if (localByName[i].MainWindowTitle == "")
                {
                    PID[j++] = localByName[i].Id;
                }
            }

            SHDocVw.ShellWindows shellWindows = new SHDocVw.ShellWindows();
            SHDocVw.InternetExplorer ieInst = shellWindows.Item();
            IntPtr hid = (IntPtr)ieInst.HWND;
            //IntPtr tabHandle = FindWindowEx(hid, IntPtr.Zero, "Frame Tab", null);
            IntPtr tabHandle = GetTopWindow(IntPtr.Zero);

            while (tabHandle != IntPtr.Zero)
            {
                GetWindowThreadProcessId(tabHandle, out processID);
                for (int i = 0; i < PID.Length; i++)
                {
                    if (PID[i] == processID)
                    {
                        GetText(tabHandle);
                    }
                }
                tabHandle = GetWindow(tabHandle, GetWindow_Cmd.GW_HWNDNEXT);
            }
        }

        enum GetWindow_Cmd : uint
        {
            GW_HWNDFIRST = 0,
            GW_HWNDLAST = 1,
            GW_HWNDNEXT = 2,
            GW_HWNDPREV = 3,
            GW_OWNER = 4,
            GW_CHILD = 5,
            GW_ENABLEDPOPUP = 6
        }

        [DllImport("user32.dll", SetLastError = true)]
        static extern IntPtr GetWindow(IntPtr hWnd, GetWindow_Cmd uCmd);

        public void GetText(IntPtr hWnd)
        {
            int length = GetWindowTextLength(hWnd);
            if (length > 0)
            {
                StringBuilder sb = new StringBuilder(length + 1);
                GetWindowText(hWnd, sb, sb.Capacity);
                if (!Regex.IsMatch(sb.ToString(), @"^MSCTFIME UI$|^Default IME$|^SysFader$|^MCI command handling window$|^GDI\+ Window$"))
                {
                    DataRow dr = browserTable.NewRow();
                    dr[0] = processID;
                    dr[1] = sb.ToString();
                    dr[2] = getTabInfo();
                    browserTable.Rows.Add(dr);
                    
                    //browserInfo.Text += ("PID: " + processID + Environment.NewLine + "Title: " + sb.ToString() + Environment.NewLine + getMemory(processID) + "MB" + Environment.NewLine);
                    
                }
            }
        }

        public string getTabInfo()
        {
            SelectQuery systemMonitorQuery = new SelectQuery("SELECT PercentProcessorTime FROM win32_PerfFormattedData_PerfProc_Process Where IDProcess = '" + processID + "'");
            ManagementObjectSearcher searchProcedure = new ManagementObjectSearcher(connectionScope, systemMonitorQuery);
            foreach (ManagementObject item in searchProcedure.Get())
            {
                return item.Properties["PercentProcessorTime"].Value.ToString();
            }
            return null;
        }

        public DataTable getBrowserTable()
        {
            return browserTable;
        }
    }
}
