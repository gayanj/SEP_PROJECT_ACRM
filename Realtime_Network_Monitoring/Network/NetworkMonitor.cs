using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using Diagnostics.Tracing;
using Diagnostics.Tracing.Parsers;
using System.Diagnostics;
using System.IO;
using System.Data;
using Npgsql;
using System.Threading.Tasks;

namespace Network
{
    class NetworkMonitor
    {
        DataTable dt = new DataTable();

        int count = 0;

        public NetworkMonitor()
        {
            dt.Columns.Add("Process Name");
            dt.Columns.Add("PID");
            dt.Columns.Add("Bytes Sent");
            dt.Columns.Add("Bytes Recieved");
            dt.Columns.Add("Total");
            dt.Columns.Add("Port");
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
                        addData(data);
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
                string PID = data.PayloadByName("PID").ToString();
                if (findPID(PID))
                {
                    Parallel.Invoke(() => updateTableRow(data, PID));
                }
                else
                {
                    Parallel.Invoke(() => addNewTableData(data, PID));
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
            DataRow row = dt.Select("PID = '" + PID + "'").First();
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
                row[5] = data.PayloadValue(5);
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
                dr[5] = data.PayloadValue(5);
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
    }
}
