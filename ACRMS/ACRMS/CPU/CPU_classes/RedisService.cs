using Newtonsoft.Json;
using ServiceStack.Redis;
using ServiceStack.Redis.Generic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACRMS.CPU.CPU_classes
{
    public class RedisService
    {
        string host = "localhost";
        int redisCount;

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
            public string name { get; set; }
            public string usage { get; set; }
        }

        public void storeInCache(Hashtable table, int id)
        {
            redisCount = id;
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
                //Store the processes and set expiry time
                processes.SetEntry(id.ToString(), process);
                redisClient.Expire(id.ToString(), 60*5);
            }
        }

        public void persistStoredCache()
        {
            using (RedisClient redisClient = new RedisClient(host))
            {
                IRedisTypedClient<CpuUsage> processes = redisClient.As<CpuUsage>();
                Dictionary<string, Process> process = new Dictionary<string, Process>();
                int previousCount = redisCount - 60;
                //Get objects for the previous minute
                for (int i = 0; i < 60; i++)
                {
                    CpuUsage processTable = processes.GetValue(previousCount.ToString());
                    ProcessArrayList response = processTable.process;
                    //check if object for id exist
                    if (processTable != null)
                    {
                        foreach (DictionaryEntry item in response.process)
                        {
                            string json = item.Value.ToString();
                            ArrayList rowItem = JsonConvert.DeserializeObject<ArrayList>(json);
                            //Exclude idle and Total processes both with PID 0
                            if (!rowItem[1].ToString().Equals("0"))
                            {
                                //check if process is already in the Dictionary
                                if (process.ContainsKey(rowItem[0].ToString()))
                                {
                                    Process listProcess;
                                    process.TryGetValue(rowItem[0].ToString(), out listProcess);
                                    //check if the new CPU usage is greater than the previous one
                                    //if so replace the new CPU usage with the old one
                                    if (Int32.Parse(listProcess.usage) < Int32.Parse(rowItem[2].ToString()))
                                    {
                                        listProcess.usage = rowItem[2].ToString();
                                        process[rowItem[0].ToString()] = listProcess;
                                    }
                                }
                                else
                                {
                                    //Add new entry to the Dictionary
                                    Process newProcess = new Process
                                    {
                                        name = rowItem[0].ToString(),
                                        usage = rowItem[2].ToString()
                                    };

                                    process.Add(rowItem[0].ToString(), newProcess);
                                }
                            }
                        }
                    }
                    previousCount++;
                }
                //Persist the final result to database
                DatabaseFactory.connectToDatabase();
                foreach(var processKey in process.Keys){
                    string sql = "INSERT INTO process_longterm_usage(name,usage) VALUES('" + process[processKey].name + "','" + process[processKey].usage + "')";
                    int result = DatabaseFactory.executeNonQuery(sql);
                    if (result < 0)
                    {
                        continue;
                    }
                }
                DatabaseFactory.closeConnection();
            }
        }
    }
}
