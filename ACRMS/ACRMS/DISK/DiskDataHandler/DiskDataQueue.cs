using System.Collections.Generic;

namespace ACRMS.DISK.DiskDataHandler
{
    using System.Windows.Forms;

    public static class DiskDataQueue
    {
        private static List<DiskDataValues> masterQueue = new List<DiskDataValues>();
        private static List<Form> formsList = new List<Form>(); 
        private static int objectCount = 0;
        
        public static int EnqueueDiskData(DiskDataValues diskDataValues)
        {
            masterQueue.Insert(objectCount, diskDataValues);
            objectCount++;
            return objectCount - 1;

        }

        public static bool DequeueDiskData(int index)
        {
            masterQueue.RemoveAt(index);
            objectCount--;
            return true;
        }

        public static bool IsInDiskQueue(string hostName, string hostIp)
        {
            for (int i = 0; i <= objectCount; i++)
            {
                if (objectCount == 0){
                    return false;
                }
                if (masterQueue[i].HostName == hostName && masterQueue[i].HostIp == hostIp)
                {
                    return true;
                }
            }
            return false;
        }

        public static string GetHostName(int index)
        {
            return masterQueue[index].HostName;
        }

        public static string GetHostIp(int index)
        {
            return masterQueue[index].HostIp;
        }

        private static int GetIndex(string hostName, string hostIp)
        {
            for (int i = 0; i <= objectCount; i++)
            {
                if (masterQueue[i].HostName == hostName && masterQueue[i].HostIp == hostIp)
                {
                    return i;
                }
            }
            return 30000000;
        }

        #region Form Handlers
        public static void AddForm(int index, Form form)
        {
            formsList.Insert(index, form);
        }

        public static Form GetForm(string hostName, string hostIp)
        {
            return formsList[GetIndex(hostName, hostIp)];
        }
        #endregion
    }
}
