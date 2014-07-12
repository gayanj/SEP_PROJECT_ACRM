using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using Diagnostics.Tracing;
using Diagnostics.Tracing.Parsers;
using System.Diagnostics;
using System.Data;
using System.Threading.Tasks;

namespace Network
{
    class NetworkMonitor
    {
        DataTable dt = new DataTable();

        private static TimeoutHandler tHandler;
        int count = 0;

        bool ready = false;

        public NetworkMonitor()
        {
            dt.Columns.Add("Process Name");
            dt.Columns.Add("PID");
            dt.Columns.Add("Bytes Sent");
            dt.Columns.Add("Bytes Recieved");
            dt.Columns.Add("Total");
            dt.Columns.Add("Port");
            tHandler = new TimeoutHandler(1);
            tHandler.SessionTimeout += tHandler_SessionTimeout;
        }

        public void MonitorNetwork()
        {
            var sessionName = "NT Kernel Logger";
            using (var session = new TraceEventSession(sessionName, null))  // the null second parameter means 'real time session'
            {
                session.StopOnDispose = true;

                using (var source = new ETWTraceEventSource(sessionName, TraceEventSourceType.Session))
                {
                    Action<TraceEvent> action = delegate(TraceEvent data)
                    {
                        if (ready)
                        {
                            tHandler = new TimeoutHandler(1);
                            tHandler.SessionTimeout += tHandler_SessionTimeout;
                            ready = false;
                            addData(data);
                        }
                    };
                    var registeredParser = new RegisteredTraceEventParser(source);
                    registeredParser.All += action;

                    session.EnableKernelProvider(KernelTraceEventParser.Keywords.NetworkTCPIP);
                    source.Process();
                }
            }
        }

        public void addData(TraceEvent data)
        {
            if (data.PayloadNames.Contains("PID"))
            {
                string ProcessId = data.PayloadByName("PID").ToString();
                if (findPID(ProcessId))
                {
                    Parallel.Invoke(() => updateTableRow(data, ProcessId));
                }
                else
                {
                    Parallel.Invoke(() => addNewTableData(data, ProcessId));
                }
            }
        }

        public bool findPID(String PID)
        {
            bool pidExist = dt.AsEnumerable().Any(row => PID == row.Field<String>("PID"));

            return pidExist;
        }

        public void updateTableRow(TraceEvent data,string PID)
        {
            DataRow row = dt.Select("PID = '" + PID + "'").FirstOrDefault();
            int total;
            try
            {
                Process pname = Process.GetProcessById(Int32.Parse(PID));
                if (data.EventName.Contains("Send") || data.EventName.Contains("Reconnect") || data.EventName.Contains("Copy"))
                {
                    row[2] = data.PayloadValue(1);
                }
                else if (data.EventName.Contains("Recv"))
                {
                    row[3] = data.PayloadValue(1);
                }
                String bytesSent = row[2].ToString();
                String bytesRec = row[3].ToString();
                if (bytesRec.Equals(""))
                    bytesRec = "0";
                if (bytesSent.Equals(""))
                    bytesSent = "0";
                total = Int32.Parse(bytesSent) + Int32.Parse(bytesRec);
                row[4] = total;
                int port = Int32.Parse(data.PayloadValue(5).ToString());
                if (port < 0)
                {
                    port = port * -1;
                }
                row[5] = port;
            }
            catch (ArgumentException e)
            {
                dt.Rows.Remove(row);
            }
        }

        public void addNewTableData(TraceEvent data,string PID)
        {
            try
            {
                DataRow dr = dt.NewRow();
                Process process = Process.GetProcessById(Int32.Parse(PID));

                string processName = process.ProcessName;
                dr[0] = processName;
                dr[1] = PID;
                if (data.EventName.Contains("Send") || data.EventName.Contains("Reconnect") || data.EventName.Contains("Copy"))
                {
                    dr[2] = data.PayloadValue(1);
                }
                else if (data.EventName.Contains("Recv"))
                {
                    dr[3] = data.PayloadValue(1);
                }
                dr[4] = 0;
                int port = Int32.Parse(data.PayloadValue(5).ToString());
                if (port < 0)
                {
                    port = port * -1;
                }
                dr[5] = port;
                dt.Rows.Add(dr);
            }
            catch (ArgumentException e)
            {
                //Process has been removed
            }
        }

        public DataTable getData()
        {
            return dt;
        }

        private void tHandler_SessionTimeout(object sender, EventArgs e)
        {
            ready = true;
        }
    }
}
