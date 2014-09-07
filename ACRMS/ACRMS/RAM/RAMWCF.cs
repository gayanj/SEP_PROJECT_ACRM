using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace ACRMS.RAM
{
    [DataContract]
    public class RAMWCF
    {
		[DataMember]
        public static uint IEProcessID;
		[DataMember]
		public static string IETitle;
		[DataMember]
		public static string IEmemory;
		[DataMember]
		public static string GCMainWindowTitle;
		[DataMember]
		public static string GCprocessName;
		[DataMember]
		public static string GCMainWindowHandle;
		[DataMember]
		public static string PrivateMemorySize;

		[DataMember]
        public static string guiActivity;
		[DataMember]
		public static string appIdleEvents;
		[DataMember]
		public static string idleState;


		[DataMember]
		public static string processName;
		[DataMember]
		public static string PID;
		[DataMember]
		public static string ProcessDescription;

		[DataMember]
        public static string ApplicationWindowTitle;
		[DataMember]
		public static string ApplicationProcessName;
		[DataMember]
		public static string ApplicationWindowHandle;
		[DataMember]
		public static string ApplicationMemoryAllocation;

		[DataMember]
		public static string PercentageCommittedBytesInUse;
		[DataMember]
		public static string AvailableBytes;
		[DataMember]
		public static string CacheBytes;
		[DataMember]
		public static string CacheBytesPeak;
		[DataMember]
		public static string CacheFaultsSec;
		[DataMember]
		public static string CommitLimit;

		[DataMember]
		public static string CommittedBytes;
		[DataMember]
		public static string DemandZeroFaults;
		[DataMember]
		public static string FreeAndZeroPageListBytes;
		[DataMember]
		public static string FreeSystemPageTableEntries;
		[DataMember]
		public static string ModifiedPageListBytes;
		[DataMember]
		public static string PageFaultsSec;
		[DataMember]
		public static string PageReadsSec;
		[DataMember]
		public static string PageWritesSec;
		[DataMember]
		public static string PageInputsSec;
		[DataMember]
		public static string PageOutputsSec;
		[DataMember]
		public static string PagesSec;
		[DataMember]
		public static string WriteCopiesSec;
		[DataMember]
		public static string PercentageOfMemoryInUse;
		[DataMember]
		public static string TotalPhysicalMemory;
		[DataMember]
		public static string TotalAvailablePhysicalMemory;
		[DataMember]
		public static string CurrentCommittedMemory;
		[DataMember]
		public static string MaxAmountCommittableMemory;
		[DataMember]
		public static string TotalVirtualMemory;
		[DataMember]
		public static string VirtualMemoryAvailable;
	    
    }

    
}
