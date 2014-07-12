using System;
using System.Runtime.InteropServices;
using System.Text;


namespace NetWatch
{
		[StructLayout(LayoutKind.Sequential)]
		public struct MIB_UDPSTATS
		{
			public int dwInDatagrams ;
			public int dwNoPorts ;
			public int dwInErrors ;
			public int dwOutDatagrams ;
			public int dwNumAddrs;
		}

		[StructLayout(LayoutKind.Sequential)]
			public struct MIB_TCPSTATS
		{
			public int dwRtoAlgorithm ;
			public int dwRtoMin ;
			public int dwRtoMax ;
			public int dwMaxConn ;
			public int dwActiveOpens ;
			public int dwPassiveOpens ;
			public int dwAttemptFails ;
			public int dwEstabResets ;
			public int dwCurrEstab ;
			public int dwInSegs ;
			public int dwOutSegs ;
			public int dwRetransSegs ;
			public int dwInErrs ;
			public int dwOutRsts ;
			public int dwNumConns ;
		}

		[StructLayout(LayoutKind.Sequential)]		public struct MIB_ICMPSTATS		{			public int dwMsgs ;			public int dwErrors;			public int dwDestUnreachs;			public int dwTimeExcds;			public int dwParmProbs;			public int dwSrcQuenchs;			public int dwRedirects;			public int dwEchos;			public int dwEchoReps;			public int dwTimestamps;			public int dwTimestampReps;			public int dwAddrMasks ;			public int dwAddrMaskReps ;		}		[StructLayout(LayoutKind.Sequential)] 		public struct MIB_ICMPINFO		{			public MIB_ICMPSTATS icmpInStats ;			public MIB_ICMPSTATS icmpOutStats ;		}
		[StructLayout(LayoutKind.Sequential)] 
			public struct MIB_IPSTATS
		{
			public int dwForwarding ;
			public int dwDefaultTTL ;
			public int dwInReceives ;
			public int dwInHdrErrors;
			public int dwInAddrErrors ;
			public int dwForwDatagrams ;
			public int dwInUnknownProtos ;
			public int dwInDiscards ;
			public int dwInDelivers ;
			public int dwOutRequests ;
			public int dwRoutingDiscards ;
			public int dwOutDiscards ;
			public int dwOutNoRoutes ;
			public int dwReasmTimeout ;
			public int dwReasmReqds ;
			public int dwReasmOks ;
			public int dwReasmFails ;
			public int dwFragOks;
			public int dwFragFails ;
			public int dwFragCreates ;
			public int dwNumIf ;
			public int dwNumAddr ;
			public int dwNumRoutes ;
		}
		
	public class IPHlpAPI32
	{
		public const byte NO_ERROR  = 0;
		public const byte MIB_TCP_RTO_CONSTANT=2;
		public const byte MIB_TCP_RTO_OTHER=1;
		public const byte MIB_TCP_RTO_RSRE=3;
		public const byte MIB_TCP_RTO_VANJ=4;
		public const int FORMAT_MESSAGE_ALLOCATE_BUFFER = 0x00000100;
		public const int FORMAT_MESSAGE_IGNORE_INSERTS = 0x00000200;
		public const int FORMAT_MESSAGE_FROM_SYSTEM  = 0x00001000;
		public int dwFlags = FORMAT_MESSAGE_ALLOCATE_BUFFER | 
			FORMAT_MESSAGE_FROM_SYSTEM | 
			FORMAT_MESSAGE_IGNORE_INSERTS;

		[DllImport("iphlpapi.dll")]
		public extern static int GetIcmpStatistics (ref MIB_ICMPINFO pStats );

		[DllImport("iphlpapi.dll")]
		public extern static int GetUdpStatistics (ref MIB_UDPSTATS pStats );

		[DllImport("iphlpapi.dll")]
		public extern static int GetTcpStatistics (ref MIB_TCPSTATS pStats );

		[DllImport("iphlpapi.dll")]
		public extern static int GetIpStatistics (ref MIB_IPSTATS pStats );

		[DllImport("iphlpapi.dll",SetLastError=true)]
		public static extern int GetTcpTable(byte[] pTcpTable, out int pdwSize, bool bOrder);

		[ DllImport( "kernel32" )]
		private static extern int FormatMessage( int flags, IntPtr source, int messageId,
			int languageId, StringBuilder buffer, int size, IntPtr arguments ); 


		public static string GetAPIErrorMessageDescription(int ApiErrNumber ) 
		{
			System.Text.StringBuilder sError = new System.Text.StringBuilder(512); 
			int lErrorMessageLength; 
			lErrorMessageLength = FormatMessage(FORMAT_MESSAGE_FROM_SYSTEM,(IntPtr)0, ApiErrNumber, 0, sError, sError.Capacity, (IntPtr)0) ;
			
			if(lErrorMessageLength > 0)
			{ 
				string strgError = sError.ToString();
				strgError=strgError.Substring(0,strgError.Length-2);
				return strgError+" ("+ApiErrNumber.ToString()+")";
			}
			return "none";

		}

		







		 
	}
}

