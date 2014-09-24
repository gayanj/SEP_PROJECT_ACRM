using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace RAM
{
    [StructLayout(LayoutKind.Sequential,CharSet=CharSet.Auto)]
    //StructLayout specifies that the fields of the type should be laid out in memory in the same order they are declared in your source code. That's often important when interoperating with native code. Without the attribute the CLR is free to optimize memory use by rearranging the fields.
    //CharSet.Auto lets the target platform determine the character width and string marshalling to Unicode or ANSI

     class MEMORYSTATUSEX   //contains current state of both physical and virtual memory.
                            //Including extended memory. 
    {
        public uint dwLength; //The size of the structure, in bytes
        public uint dwMemoryLoad; //A number between 0 and 100 that specifies the approximate percentage of physical memory that is in use 
        public ulong ullTotalPhys; //The amount of actual physical memory, in bytes.
        public ulong ullAvailPhys; //The amount of physical memory currently available, in bytes. This is the amount of physical memory that can be immediately reused without having to write its contents to disk first
        public ulong ullTotalPageFile; //The current committed memory limit for the system or the current process.
        public ulong ullAvailPageFile; //The maximum amount of memory the current process can commit in bytes.
        public ulong ullTotalVirtual; //The size of the user-mode portion of the virtual address space of the calling process, in bytes.
        public ulong ullAvailVirtual; //The amount of unreserved and uncommitted memory currently in the user-mode portion of the virtual address space of the calling process, in bytes.
        public ulong ullAvailExtendedVirtual;

        public MEMORYSTATUSEX()
        {
            this.dwLength = (uint)Marshal.SizeOf(typeof(MEMORYSTATUSEX));//to allocate some memory in the unmanaged heap to call a native API.cannot use sizeOf for referneces.

        }
        [return: MarshalAs(UnmanagedType.Bool)] 
        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)] 
        public static extern bool GlobalMemoryStatusEx(MEMORYSTATUSEX buffer);

        public void setValues()
        {
            MEMORYSTATUSEX statusEx=new MEMORYSTATUSEX();
            bool Success = GlobalMemoryStatusEx(statusEx); //to determine how much memory your application can allocate without severely impacting other applications.
            this.dwMemoryLoad = statusEx.dwMemoryLoad;
            //Console.WriteLine("from main" + graphMemory);
            this.ullTotalPhys = statusEx.ullTotalPhys;
            this.ullAvailPhys = statusEx.ullAvailPhys;
            this.ullTotalPageFile = statusEx.ullTotalPageFile;
            this.ullAvailPageFile = statusEx.ullAvailPageFile;
            this.ullTotalVirtual = statusEx.ullTotalVirtual;
            this.ullAvailVirtual = statusEx.ullAvailVirtual;
            this.ullAvailExtendedVirtual = statusEx.ullAvailExtendedVirtual;
        }

        public double convertToBytes(ulong bytes)
        {

            return (bytes / 1024f) / 1024f;
        }
     }
    
}
