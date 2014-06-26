using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Diagnostics.Tracing;
using Diagnostics.Tracing.Parsers;
using System.Diagnostics;
using System.IO;
using System.Data;
using RealTimeEventTracing;
using Npgsql;

namespace RealTimeEventTracing.Network
{
    class NetworkMonitor
    {
        public delegate void TableEventHandler(object sender,UpdateEvent args);

        public event TableEventHandler updateTable;

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
                    updateTableRow(data,PID);
                }
                else
                {
                    addNewTableData(data,PID);
                }
            }
        }

        public bool findPID(String PID)
        {
            string sql = "SELECT n.pid FROM network n WHERE n.pid = '"+PID+"'";
            DataSet ds = new DataSet();
            NpgsqlDataAdapter data = DatabaseFactory.executeQuery(sql);
            data.Fill(ds);
            if (ds.Tables[0].Rows.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void updateTableRow(TraceEvent data,string PID)
        {

        }

        public void addNewTableData(TraceEvent data,string PID)
        {
            //DataRow dr = dt.NewRow();
            Process processName = Process.GetProcessById(Int32.Parse(PID));
            //dr[0] = processName;
            //dr[1] = PID;
            string bsent = "";
            string brec = "";
            string total = "0";
            string port = data.PayloadValue(5).ToString();
            if (data.EventName.Contains("Send") || data.EventName.Contains("Reconnect") || data.EventName.Contains("Copy"))
            {
                bsent = data.PayloadValue(1).ToString();
                //dr[2] = data.PayloadValue(1);
            }
            else if (data.EventName.Contains("Recv"))
            {
                brec = data.PayloadValue(1).ToString();
                //dr[3] = data.PayloadValue(1);
            }
            //dr[4] = 0;
            //dr[5] = data.PayloadValue(5);
            count++;
            string sql = "INSERT INTO network VALUES('"+count.ToString()+"','" + PID + "','" + processName.ToString() + "','" + bsent + "','" + brec + "','" + total + "','" + port + "')";
            //dt.Rows.Add(dr);
            //DatabaseFactory.connectToDatabase();
            DatabaseFactory.executeNonQuery(sql);
            UpdateEvent args = new UpdateEvent();

            if (updateTable != null)
                updateTable(this, args);
        }
    }
}
