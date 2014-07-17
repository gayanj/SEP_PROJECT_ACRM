using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SEPMetro
{
    public partial class Browser : Form
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
        public Browser()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show("Internet Explorer Not Running, Please Try Again");
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

                    browserInfo.Text += ("PID: " + processID + Environment.NewLine + "Title: " + sb.ToString() + Environment.NewLine + getMemory(processID) + "MB" + Environment.NewLine);
                    
                }
            }
        }

        public static long getMemory(long processid)
        {
            foreach (Process p in Process.GetProcesses(".")) //Creates a new Process component for each process resource on the specified computer.
            {
                if (p.Id == processid)
                {
                    try
                    {
                        return p.PrivateMemorySize64 / 1024 / 1024;
                    }
                    catch
                    {
                    }
                }
            }
            return 0;
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
                foreach (Process p in Process.GetProcesses(".")) //Creates a new Process component for each process resource on the specified computer.
                {
                    if(p.ProcessName.Equals("chrome"))
                    {
                        try
                        {
                            if (p.MainWindowTitle.Length > 0)
                            {
                                browserInfo.Text+=("Window Title:\t" + p.MainWindowTitle.ToString() + Environment.NewLine)
                                +("Process Name:\t" + p.ProcessName.ToString() + Environment.NewLine)
                                +("Window Handle:\t" + p.MainWindowHandle.ToString() + Environment.NewLine)
                                +("Memory Allocation:\t" + p.PrivateMemorySize64.ToString() + " Bytes" + Environment.NewLine)
                                +(Environment.NewLine);
                            }
                        }
                        catch(Exception ex)
                        {
                            browserInfo.Text = ex.ToString();
                            MessageBox.Show("Chrome is Not Running. Please Try Again");
                        }
                    }
                }
            }

        }


    }

