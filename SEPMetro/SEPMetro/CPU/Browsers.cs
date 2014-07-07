using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ACRM.CPU;
using System.Diagnostics;

namespace SEPMetro.CPU
{
    class Browsers
    {
        static uint processID;

        [DllImport("user32.dll", SetLastError = true)]
        public static extern uint GetWindowThreadProcessId(IntPtr hWnd, out uint lpdwProcessId);

        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        static extern int GetWindowTextLength(IntPtr hWnd);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        static extern int GetWindowText(IntPtr hWnd, StringBuilder lpString, int nMaxCount);

        [DllImport("user32.dll")]
        static extern IntPtr GetTopWindow(IntPtr hWnd);

        string IEcpuUsage = "";
        string ChromecpuUsage = "";

        public string IE()
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
            return IEcpuUsage;
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
                    ProcessLocal pl = new ProcessLocal();
                    string usage = pl.returnUsageForProcess(Int32.Parse(processID.ToString()));
                    IEcpuUsage += ("PID: " + processID + Environment.NewLine + "CPU Usage: " + sb.ToString() + Environment.NewLine + usage + "%" + Environment.NewLine);
                }
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

        public string Chrome()
        {
            int j = 0;
            Process[] localByName = Process.GetProcessesByName("chrome");
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
                        ChromeGetText(tabHandle);
                    }
                }
                tabHandle = GetWindow(tabHandle, GetWindow_Cmd.GW_HWNDNEXT);
            }
            return ChromecpuUsage;
        }

        public void ChromeGetText(IntPtr hWnd)
        {
            int length = GetWindowTextLength(hWnd);
            if (length > 0)
            {
                StringBuilder sb = new StringBuilder(length + 1);
                GetWindowText(hWnd, sb, sb.Capacity);
                if (!Regex.IsMatch(sb.ToString(), @"^MSCTFIME UI$|^Default IME$|^SysFader$|^MCI command handling window$|^GDI\+ Window$"))
                {
                    ProcessLocal pl = new ProcessLocal();
                    string usage = pl.returnUsageForProcess(Int32.Parse(processID.ToString()));
                    IEcpuUsage += ("PID: " + processID + Environment.NewLine + "CPU Usage: " + sb.ToString() + Environment.NewLine + usage + "%" + Environment.NewLine);
                }
            }
        }
    }
}
