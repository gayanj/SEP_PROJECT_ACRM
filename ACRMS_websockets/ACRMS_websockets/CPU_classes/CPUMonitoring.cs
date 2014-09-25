using ACRMS.CPU;
using ACRMS.CPU.CPU_classes;
using DataWareHouse;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace ACRMS_websockets.CPU_classes
{
    public class CPUMonitoring
    {
        Hashtable monitoringProcesses = new Hashtable();
        int waitTime = 2;
        bool previousUsage = false;
        DB_Access sqldb = new DB_Access();
        System.Timers.Timer t1;
        System.Timers.Timer t2;
        ProcessLocal pl = new ProcessLocal();
        RedisService redisService = new RedisService();
        int count = 0;

        public CPUMonitoring()
        {
            t1 = new System.Timers.Timer(1000);
            t2 = new System.Timers.Timer(10000);
        }

        private void RedisMonitoringService(object sender, ElapsedEventArgs e)
        {
            redisService.storeInCache(pl.ClientMonitor(), ++count);
            if (count == 60)
            {
                ThreadPool.QueueUserWorkItem(state => redisService.persistStoredCache(1));
            }
            if (count == 120)
            {
                count = 0;
                ThreadPool.QueueUserWorkItem(state => redisService.persistStoredCache(61));
            }
        }

        public void StartPersistingData()
        {
            t1.Elapsed += new ElapsedEventHandler(RedisMonitoringService);
            t1.Enabled = true;
        }

        public void MonitorCPUUsage(object sender, ElapsedEventArgs e)
        {
            //int usage = pl.GetCpuUsage();
            //if (usage > 90)
            //{
            //    if (!previousUsage)
            //    {
            //        //alert user
            //        ACRMS.notifyIcon1.ShowBalloonTip(1000, "CPU Usage", "Your CPU Usage is " + usage, ToolTipIcon.Warning);
            //        previousUsage = true;
            //        sqldb.persistCPUAlert("Your CPU Usage exceeded " + usage + "%");
            //        //query database to predict if the crash is going to happen and give appropriate suggestions.
            //    }
            //}
            //else
            //{
            //    previousUsage = false;
            //}

            Hashtable processData = pl.GetTrackProcessData();
            List<string> keys = new List<string>();
            foreach (DictionaryEntry item in processData)
                keys.Add(item.Key.ToString());
            foreach (string key in keys)
            {
                ArrayList rowItem = (ArrayList)processData[key];
                if (!rowItem[1].ToString().Equals("0"))
                {
                    //check if process has exceeded the usage limit
                    if (pl.GetProcessData(rowItem[0].ToString()) > 5)
                    {
                        if (!monitoringProcesses.ContainsKey(rowItem[0].ToString()))
                        {
                            monitoringProcesses.Add(rowItem[0].ToString(), rowItem[0].ToString());
                            ThreadPool.QueueUserWorkItem(state => trackProcess(rowItem));
                        }
                    }
                }
            }
        }

        public void trackProcess(ArrayList processDetails)
        {
            int counterTime = waitTime;
            float highestUsage = 0;
            ArrayList pDetails = processDetails;
            //to do add exception handler
            string pname = pDetails[0].ToString();

            while (counterTime > 0)
            {
                float usage = pl.GetProcessData(pname);
                Console.WriteLine(usage);
                Console.WriteLine("Counter :" + counterTime);
                if (usage > 5)
                {
                    if (usage > highestUsage)
                        highestUsage = usage;
                    counterTime--;
                    Thread.Sleep(1000);
                    continue;
                }
                else
                {
                    break;
                }
            }
            monitoringProcesses.Remove(pname);
            if (counterTime == 0)
            {
                ACRMS.notifyIcon1.ShowBalloonTip(1000, "CPU Usage", "CPU Usage exceeded " + highestUsage + "% for Process " + pname, ToolTipIcon.Warning);
                sqldb.persistCPUAlert("CPU Usage exceeded " + highestUsage + "%", pname);
            }
        }

        public void StartCPUMonitoring()
        {
            t2.Elapsed += new ElapsedEventHandler(MonitorCPUUsage);
            t2.Enabled = true;
        }
    }
}