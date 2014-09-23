using DataWareHouse;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack.Redis;
using ServiceStack.Redis.Generic;

namespace ACRMS.CPU.CPU_classes
{
    public class RedisService
    {
        string host = "localhost";
        //ConnectionMultiplexer redis = ConnectionMultiplexer.Connect("localhost");
        DB_Access sqldb = new DB_Access();

        public class CpuUsage
        {
            public int id { get; set; }
            public ProcessArrayList process { get; set; }
        }

        public class ProcessArrayList
        {
            public Hashtable process { get; set; }
        }

        public class Process
        {
            public string UsageDateKey { get; set; }
            public string UsageTimeKey { get; set; }
            public string Name { get; set; }
            public string CreatingProcessID { get; set; }
            public string ElapsedTime { get; set; }
            public string HandleCount { get; set; }
            public string IDProcess { get; set; }
            public string PercentProcessorTime { get; set; }
            public string PercentUserTime { get; set; }
            public string ThreadCount { get; set; }
        }

        public void storeInCache(Hashtable table, int id)
        {
            //IDatabase db = redis.GetDatabase();
            using (RedisClient redisClient = new RedisClient(host))
            {
                IRedisTypedClient<CpuUsage> processes = redisClient.As<CpuUsage>();
                CpuUsage process = new CpuUsage
                {
                    id = id,
                    process = new ProcessArrayList
                    {
                        process = table
                    }
                };
                processes.SetEntry(id.ToString(), process);
                redisClient.Expire(id.ToString(), 120);
            }
            //CpuUsage process = new CpuUsage
            //{
            //    id = id,
            //    process = new ProcessArrayList
            //    {
            //        process = table
            //    }
            //};
            ////Store the processes and set expiry time
            //string value = JsonConvert.SerializeObject(process);
            //db.StringSet(id.ToString(), value);
            //db.KeyExpire(id.ToString(), DateTime.Now.AddMinutes(2));
        }

        public void persistStoredCache(int startCount)
        {
            //IDatabase db = redis.GetDatabase();
            using (RedisClient redisClient = new RedisClient(host))
            {
                IRedisTypedClient<CpuUsage> processes = redisClient.As<CpuUsage>();
                Dictionary<string, Process> process = new Dictionary<string, Process>();
                //Get objects for the previous minute
                for (int i = 0; i < 60; i++)
                {
                    //CpuUsage processTable = JsonConvert.DeserializeObject<CpuUsage>(db.StringGet(startCount.ToString()));
                    CpuUsage processTable = processes.GetValue(startCount.ToString());
                    ProcessArrayList response = processTable.process;
                    //check if object for id exist
                    if (processTable != null)
                    {
                        foreach (DictionaryEntry item in response.process)
                        {
                            string json = item.Value.ToString();
                            ArrayList rowItem = JsonConvert.DeserializeObject<ArrayList>(json);
                            //Exclude idle and Total processes both with PID 0
                            if (!rowItem[6].ToString().Equals("0"))
                            {
                                //check if process is already in the Dictionary
                                if (process.ContainsKey(rowItem[2].ToString()))
                                {
                                    Process listProcess;
                                    process.TryGetValue(rowItem[2].ToString(), out listProcess);
                                    //check if the new CPU usage is greater than the previous one
                                    //if so replace the new CPU usage with the old one
                                    if (Int32.Parse(listProcess.PercentProcessorTime) < Int32.Parse(rowItem[7].ToString()))
                                    {
                                        listProcess.UsageDateKey = rowItem[0].ToString();
                                        listProcess.UsageTimeKey = rowItem[1].ToString();
                                        listProcess.CreatingProcessID = rowItem[3].ToString();
                                        listProcess.ElapsedTime = rowItem[4].ToString();
                                        listProcess.HandleCount = rowItem[5].ToString();
                                        listProcess.IDProcess = rowItem[6].ToString();
                                        listProcess.PercentProcessorTime = rowItem[7].ToString();
                                        listProcess.PercentUserTime = rowItem[8].ToString();
                                        listProcess.ThreadCount = rowItem[9].ToString();

                                        process[rowItem[0].ToString()] = listProcess;
                                    }
                                }
                                else
                                {
                                    //Add new entry to the Dictionary
                                    Process newProcess = new Process
                                    {
                                        UsageDateKey = rowItem[0].ToString(),
                                        UsageTimeKey = rowItem[1].ToString(),
                                        Name = rowItem[2].ToString(),
                                        CreatingProcessID = rowItem[3].ToString(),
                                        ElapsedTime = rowItem[4].ToString(),
                                        HandleCount = rowItem[5].ToString(),
                                        IDProcess = rowItem[6].ToString(),
                                        PercentProcessorTime = rowItem[7].ToString(),
                                        PercentUserTime = rowItem[8].ToString(),
                                        ThreadCount = rowItem[9].ToString()
                                    };
                                    process.Add(rowItem[2].ToString(), newProcess);
                                }
                                //check if process is in the database
                                //if process is not there store the new process name
                                if (!sqldb.checkIfProcessExist(rowItem[2].ToString()))
                                {
                                    sqldb.persistProcessName(rowItem[2].ToString());
                                }
                            }
                        }
                    }
                    startCount++;
                }
                //Persist the final result to database
                foreach (var processKey in process.Keys)
                {
                    string processId = sqldb.getProcessKey(process[processKey].Name);
                    sqldb.persistData(process[processKey].UsageDateKey, process[processKey].UsageTimeKey, processId, process[processKey].CreatingProcessID, process[processKey].ElapsedTime, process[processKey].HandleCount, process[processKey].IDProcess, process[processKey].PercentProcessorTime, process[processKey].PercentUserTime, process[processKey].ThreadCount);
                }
            }
        }
    }
}