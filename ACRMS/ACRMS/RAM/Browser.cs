using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ACRMS;
using ACRMS.RAM;

namespace SEPMetro
{
    public partial class Browser : Form
    {
        public static String alertMessageChrome;
        public static String alertMessageIE;
        static uint processID;
        String title;
        String memory;
        SqlConnection myConnection;
        System.Windows.Forms.Timer dbTick;
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
            String connectionString = "Data Source=DELL-PC\\MSSQLSERVER2014;Initial Catalog=RAMDataWareHouse;Integrated Security=True";
            myConnection = new SqlConnection(connectionString);
            //dbTick = new System.Windows.Forms.Timer { Enabled = true, Interval = Settings.chromeAlertTime };
            //dbTick.Tick += tick_dbTick;
            inputToDataWareHouse();

        }

        public void inputToDataWareHouse()
        {
             SqlCommand cmd = new SqlCommand("SELECT DateKey from DimDate", myConnection);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    for (int k = 0; k < 8639; k = k + 60)
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

                            if (Int32.Parse(memory) > Settings.IEMemoryUsage)
                                alertMessageIE = "Internet Explorer tab " + title + " has exceeded " + Settings.IEMemoryUsage + ". Current value is " + memory + "MB.";

                            try
                            {
                                myConnection.Open();
                                string query = "INSERT INTO FactIEMemory(AgentID,IEPid,IETitle,IEMemory,DateKey,TimeKey)" + "VALUES(1,'" + processID + "','" + title + "','" + memory + Int32.Parse(dr["DateKey"].ToString()) + "','" + k + "')";
                                //RAMWCF.IEProcessID = processID;
                                //RAMWCF.IETitle = title;
                                //RAMWCF.IEmemory = memory;

                                SqlCommand insertQuery = new SqlCommand(query, myConnection);
                                insertQuery.ExecuteNonQuery();

                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("cannot open SQL connection " + ex);
                            }
                            myConnection.Close();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Internet Explorer Not Running, Please Try Again");
                        }


                        StringBuilder sb = new StringBuilder();
                        foreach (Process p in Process.GetProcesses(".")) //Creates a new Process component for each process resource on the specified computer.
                        {
                            if (p.ProcessName.Equals("chrome"))
                            {
                                try
                                {
                                    if (p.MainWindowTitle.Length > 0)
                                    {
                                        if (Int32.Parse(p.PrivateMemorySize64.ToString()) > Settings.chromeMemoryUsage)
                                            alertMessageChrome = "Chrome tab " + p.MainWindowTitle.ToString() + " has exceeded " + Settings.chromeMemoryUsage + ". Current value is " + p.PrivateMemorySize64.ToString() + "Bytes.";

                                        try
                                        {
                                            myConnection.Open();
                                            string query = "INSERT INTO FactGCMemory(AgentID,GCTitle,GCProcessName,GCWindowHandle,GCMemory,DateKey,TimeKey)" + "VALUES(1,'" + p.MainWindowTitle.ToString() + "','" + p.ProcessName.ToString() + "','" + p.MainWindowHandle.ToString() + "','" + p.PrivateMemorySize64.ToString() + Int32.Parse(dr["DateKey"].ToString()) + "','" + k + "')";
                                            //RAMWCF.GCMainWindowTitle = p.MainWindowTitle;
                                            //RAMWCF.GCprocessName = p.MainWindowTitle.ToString();
                                            //RAMWCF.GCMainWindowHandle = p.MainWindowHandle.ToString();
                                            //RAMWCF.PrivateMemorySize = p.PrivateMemorySize64.ToString();
                                            SqlCommand insertQuery = new SqlCommand(query, myConnection);
                                            insertQuery.ExecuteNonQuery();
                                        }
                                        catch (Exception ex)
                                        {
                                            Console.WriteLine("cannot open SQL connection " + ex);
                                        }
                                        myConnection.Close();
                                    }
                                }
                                catch (Exception ex)
                                {
                                    browserInfo.Text = ex.ToString();
                                    Console.WriteLine("Chrome is Not Running. Please Try Again");
                                }
                            }
                        }

                        Thread.Sleep(60000);
                    }

                }
        }


        private void metroButton1_Click(object sender, EventArgs e)
        {
            
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
                    title=sb.ToString();
                    memory=getMemory(processID).ToString();
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

        private void Browser_Load(object sender, EventArgs e)
        {
           
        }


        void tick_dbTick(object sender, EventArgs e)
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

                if(Int32.Parse(memory)>Settings.IEMemoryUsage)
                alertMessageIE = "Internet Explorer tab " + title + " has exceeded " + Settings.IEMemoryUsage + ". Current value is " + memory + "MB.";

                try
                {
                    myConnection.Open();
                    string query = "INSERT INTO IEMemory(AgentID,IEPid,IETitle,IEMemory)" + "VALUES(1,'" + processID + "','" + title + "','" + memory + "')";
                    string query2 = "INSERT INTO Alerts(AgentID,dTime,message)" + "VALUES(1,'" + DateTime.Now.ToString() + "','" + alertMessageIE + "')";
                    RAMWCF.IEProcessID = processID;
                    RAMWCF.IETitle = title;
                    RAMWCF.IEmemory = memory;

                    SqlCommand insertQuery = new SqlCommand(query, myConnection);
                    SqlCommand insertQuery2 = new SqlCommand(query2, myConnection);
                    insertQuery.ExecuteNonQuery();
                    insertQuery2.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("cannot open SQL connection " + ex);
                }
                myConnection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Internet Explorer Not Running, Please Try Again");
            }


            StringBuilder sb = new StringBuilder();
            foreach (Process p in Process.GetProcesses(".")) //Creates a new Process component for each process resource on the specified computer.
            {
                if (p.ProcessName.Equals("chrome"))
                {
                    try
                    {
                        if (p.MainWindowTitle.Length > 0)
                        {
                            if (Int32.Parse(p.PrivateMemorySize64.ToString()) > Settings.chromeMemoryUsage)
                                alertMessageChrome = "Chrome tab " + p.MainWindowTitle.ToString() + " has exceeded " + Settings.chromeMemoryUsage + ". Current value is " + p.PrivateMemorySize64.ToString() + "Bytes.";

                            try
                            {
                                myConnection.Open();
                                string query = "INSERT INTO GCMemory(AgentID,GCTitle,GCProcessName,GCWindowHandle,GCMemory)" + "VALUES(1,'" + p.MainWindowTitle.ToString() + "','" + p.ProcessName.ToString() + "','" + p.MainWindowHandle.ToString() + "','" + p.PrivateMemorySize64.ToString() + "')";
                                string query2 = "INSERT INTO Alerts(AgentID,dTime,message)" + "VALUES(1,'" + DateTime.Now.ToString() + "','" + alertMessageChrome + "')";
                                RAMWCF.GCMainWindowTitle = p.MainWindowTitle;
                                RAMWCF.GCprocessName = p.MainWindowTitle.ToString();
                                RAMWCF.GCMainWindowHandle = p.MainWindowHandle.ToString();
                                RAMWCF.PrivateMemorySize = p.PrivateMemorySize64.ToString();
                                SqlCommand insertQuery = new SqlCommand(query, myConnection);
                                SqlCommand insertQuery2 = new SqlCommand(query2, myConnection);
                                insertQuery.ExecuteNonQuery();
                                insertQuery2.ExecuteNonQuery();
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("cannot open SQL connection " + ex);
                            }
                            myConnection.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        browserInfo.Text = ex.ToString();
                        Console.WriteLine("Chrome is Not Running. Please Try Again");
                    }
                }
            }


           
        }

        }


    }

