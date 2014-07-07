using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace ACRM.RAM
{
    public static class Native
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct PROCESSENTRY32
        {
            public uint dwSize;
            public uint cntUsage;
            public uint th32ProcessID;
            public IntPtr th32DefaultHeapID;
            public uint th32ModuleID;
            public uint cntThreads;
            public uint th32ParentProcessID;
            public int pcPriClassBase;
            public uint dwFlags;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
            public string szExeFile;
        };

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct MODULEENTRY32
        {
            public uint dwSize;
            public uint th32ModuleID;
            public uint th32ProcessID;
            public uint GlblcntUsage;
            public uint ProccntUsage;
            public IntPtr modBaseAddr;
            public uint modBaseSize;
            IntPtr hModule;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
            public string szModule;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
            public string szExePath;
        };

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
        public struct THREADENTRY32
        {

            internal UInt32 dwSize;
            internal UInt32 cntUsage;
            internal UInt32 th32ThreadID;
            internal UInt32 th32OwnerProcessID;
            internal UInt32 tpBasePri;
            internal UInt32 tpDeltaPri;
            internal UInt32 dwFlags;
        };

        [StructLayout(LayoutKind.Sequential)]
        struct HEAPLIST32
        {
            public UIntPtr dwSize;
            public uint th32ProcessID;
            public UIntPtr th32HeapID;
            public uint dwFlags;
        };

        [StructLayout(LayoutKind.Sequential)]
        struct HEAPENTRY32
        {
            public UIntPtr dwSize;
            public IntPtr hHandle;
            public UIntPtr dwAddress;
            public UIntPtr dwBlockSize;
            public uint dwFlags;
            public uint dwLockCount;
            public uint dwResvd;
            public uint th32ProcessID;
            public UIntPtr th32HeapID;
        };

        [DllImport("kernel32.dll")]
        static extern bool Process32Next(IntPtr hSnapshot, ref PROCESSENTRY32 lppe);

        [DllImport("kernel32.dll")]
        static extern bool Process32First(IntPtr hSnapshot, ref PROCESSENTRY32 lppe);

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern IntPtr CreateToolhelp32Snapshot(uint dwFlags, uint th32ProcessID);

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool CloseHandle(IntPtr hObject);

        [DllImport("kernel32.dll")]
        public static extern IntPtr OpenProcess(int dwDesiredAccess, bool bInheritHandle, int dwProcessId);

        [DllImport("kernel32.dll")]
        static extern uint GetPriorityClass(IntPtr hProcess);

        [DllImport("kernel32.dll")]
        static extern bool Module32First(IntPtr hSnapshot, ref MODULEENTRY32 lpme);

        [DllImport("kernel32.dll")]
        static extern bool Module32Next(IntPtr hSnapshot, ref MODULEENTRY32 lpme);

        [DllImport("kernel32.dll")]
        static extern bool Thread32First(IntPtr hSnapshot, ref THREADENTRY32 lpte);

        [DllImport("kernel32.dll")]
        static extern bool Thread32Next(IntPtr hSnapshot, out THREADENTRY32 lpte);

        [DllImport("kernel32.dll")]
         static extern bool Heap32ListFirst(IntPtr hSnapshot, ref HEAPLIST32 lphl);

        [DllImport("kernel32.dll")]
         static extern bool Heap32ListNext(IntPtr hSnapshot, ref HEAPLIST32 lphl);

        [DllImport("Kernel32.dll", EntryPoint = "RtlZeroMemory", SetLastError = false)]
        static extern void ZeroMemory(IntPtr dest, IntPtr size);

        [DllImport("kernel32.dll")]
        static extern bool Heap32First(ref HEAPENTRY32 lphe, uint th32ProcessID, UIntPtr th32HeapID);

        [DllImport("kernel32.dll")]
         static extern bool Heap32Next(ref HEAPENTRY32 lphe);

        public static Process ParentProcess(this Process process)
        {
            int parentPid = 0;
            int processPid = process.Id;
            uint TH32CS_SNAPPROCESS = 2;

            IntPtr hSnapshot = CreateToolhelp32Snapshot(TH32CS_SNAPPROCESS, 0);

            if (hSnapshot == IntPtr.Zero)
            {
                return null;
            }

            PROCESSENTRY32 procInfo = new PROCESSENTRY32();

            procInfo.dwSize = (uint)Marshal.SizeOf(typeof(PROCESSENTRY32));

            if (Process32First(hSnapshot, ref procInfo) == false)
            {
                return null;
            }

            do
            {
                if (processPid == procInfo.th32ProcessID)
                {
                    parentPid = (int)procInfo.th32ParentProcessID;
                }
            }
            while (parentPid == 0 && Process32Next(hSnapshot, ref procInfo)); // Read next

            if (parentPid > 0)
            {
                return Process.GetProcessById(parentPid);
            }

            else
            {
                return null;
            }
        }


        public static Boolean GetProcessList()
        {
            int PROCESS_ALL_ACCESS = 0x1F0FFF;
            IntPtr hProcessSnap;
            IntPtr hProcess;
            PROCESSENTRY32 pe32 = new PROCESSENTRY32();
            uint dwPriorityClass;
            uint TH32CS_SNAPPROCESS = 2;
            // Take a snapshot of all processes in the system.
            hProcessSnap = CreateToolhelp32Snapshot(TH32CS_SNAPPROCESS, 0);
            IntPtr INVALID_HANDLE_VALUE = new IntPtr(-1);
            if (hProcessSnap == INVALID_HANDLE_VALUE)
            {
                Console.WriteLine("CreateToolhelp32Snapshot (of processes)");
                return false;
            }
            // Set the size of the structure before using it.
            pe32.dwSize = (uint)Marshal.SizeOf(typeof(PROCESSENTRY32));
            // Retrieve information about the first process,
            // and exit if unsuccessful
            if (!Process32First(hProcessSnap, ref pe32))
            {
                Console.WriteLine("Process32First");
                CloseHandle(hProcessSnap);
                return false;
            }
            //walk the snapshot of processes, and
            // display information about each process in turn
            do
            {
                Console.WriteLine("\n\n=====================================================");
                Console.WriteLine("Process Name " + pe32.szExeFile);
                // Retrieve the priority class.
                dwPriorityClass = 0;
                hProcess = OpenProcess(PROCESS_ALL_ACCESS, false, (int)pe32.th32ProcessID);
                if (hProcess == null)
                    Console.WriteLine("OpenProcess");
                else
                {
                    dwPriorityClass = GetPriorityClass(hProcess);
                    CloseHandle(hProcess);

                }
               
                Console.WriteLine("\n Process ID " + pe32.th32ProcessID);
                Console.WriteLine("\n ThreadCount " + pe32.cntThreads);
                Console.WriteLine("\n Parent process Id " + pe32.th32ParentProcessID);
                Console.WriteLine("\n PriorityBase " + pe32.pcPriClassBase);
                Console.WriteLine("\n Priority Class " + dwPriorityClass);

                ListProcessModules(pe32.th32ProcessID);
             //   ListProcessThreads(pe32.th32ProcessID);
                //ListHeap(pe32.th32ProcessID);

            }
            while (Process32Next(hProcessSnap, ref pe32));
            CloseHandle(hProcessSnap);
            return true;

        }

        public static Boolean ListProcessModules(uint dwPID)
        {
            IntPtr INVALID_HANDLE_VALUE = new IntPtr(-1);
            IntPtr hModuleSnap = INVALID_HANDLE_VALUE;
            MODULEENTRY32 me32 = new MODULEENTRY32();
            uint TH32CS_SNAPHEAPLIST = 0x00000001;
            uint TH32CS_SNAPPROCESS = 0x00000002;
            uint TH32CS_SNAPTHREAD = 0x00000004;
            uint TH32CS_SNAPMODULE = 0x00000008;
            uint TH32CS_SNAPMODULE32 = 0x00000010;
            uint TH32CS_SNAPALL = (TH32CS_SNAPHEAPLIST |
                                                 TH32CS_SNAPPROCESS |
                                                 TH32CS_SNAPTHREAD |
                                                 TH32CS_SNAPMODULE);
            hModuleSnap = CreateToolhelp32Snapshot(TH32CS_SNAPMODULE, dwPID);
            if (hModuleSnap == INVALID_HANDLE_VALUE)
                return false;
            me32.dwSize = (uint)Marshal.SizeOf(typeof(MODULEENTRY32));
            if (!Module32First(hModuleSnap, ref me32))
            {
                CloseHandle(hModuleSnap);
                return false;
            }
            do
            {
                Console.WriteLine("\n\n Module Name " + me32.szModule);
                Console.WriteLine("\n Executable " + me32.szExePath);
                Console.WriteLine("\n Process ID " + me32.th32ProcessID);
                Console.WriteLine("\n Ref Count(g) " + me32.GlblcntUsage);
                Console.WriteLine("\n Ref Count(p) " + me32.ProccntUsage);
                Console.WriteLine("\n Base address " + me32.modBaseAddr);
                Console.WriteLine("\n Base size " + me32.modBaseSize);

            } while (Module32Next(hModuleSnap, ref me32));

            CloseHandle(hModuleSnap);
            return true;

        }

        public static Boolean ListProcessThreads(uint dwOwnerPID)
        {
            IntPtr INVALID_HANDLE_VALUE = new IntPtr(-1);
            IntPtr hThreadSnap = INVALID_HANDLE_VALUE;
            THREADENTRY32 te32 = new THREADENTRY32();
            uint TH32CS_SNAPHEAPLIST = 0x00000001;
            uint TH32CS_SNAPPROCESS = 0x00000002;
            uint TH32CS_SNAPTHREAD = 0x00000004;
            uint TH32CS_SNAPMODULE = 0x00000008;
            uint TH32CS_SNAPMODULE32 = 0x00000010;
            uint TH32CS_SNAPALL = (TH32CS_SNAPHEAPLIST |
                                                 TH32CS_SNAPPROCESS |
                                                 TH32CS_SNAPTHREAD |
                                                 TH32CS_SNAPMODULE);
            hThreadSnap = CreateToolhelp32Snapshot(TH32CS_SNAPTHREAD, 0);
            if (hThreadSnap == INVALID_HANDLE_VALUE)
                return false;
            te32.dwSize = (uint)Marshal.SizeOf(typeof(THREADENTRY32));
            if (!Thread32First(hThreadSnap, ref te32))
            {
                CloseHandle(hThreadSnap);
                return false;
            }
            do
            {
                Console.WriteLine("\n\n Thread Id " + te32.th32ThreadID);
                Console.WriteLine("\n Base Priority " + te32.tpBasePri);
                Console.WriteLine("\n Delta Priority " + te32.tpDeltaPri);
                Console.WriteLine("\n");


            } while (Thread32Next(hThreadSnap, out te32));

            CloseHandle(hThreadSnap);
            return true;

        }

        public static Boolean ListHeap(uint dwPID)
        {
            HEAPLIST32 hl = new HEAPLIST32();
            IntPtr INVALID_HANDLE_VALUE = new IntPtr(-1);
            IntPtr hHeapSnap = INVALID_HANDLE_VALUE;

            uint TH32CS_SNAPHEAPLIST = 0x00000001;
            uint TH32CS_SNAPPROCESS = 0x00000002;
            uint TH32CS_SNAPTHREAD = 0x00000004;
            uint TH32CS_SNAPMODULE = 0x00000008;
            uint TH32CS_SNAPMODULE32 = 0x00000010;
            uint TH32CS_SNAPALL = (TH32CS_SNAPHEAPLIST |
                                                 TH32CS_SNAPPROCESS |
                                                 TH32CS_SNAPTHREAD |
                                                 TH32CS_SNAPMODULE);
            hHeapSnap = CreateToolhelp32Snapshot(TH32CS_SNAPHEAPLIST, dwPID);
            if (hHeapSnap == INVALID_HANDLE_VALUE)
                return false;
            hl.dwSize =(UIntPtr) Marshal.SizeOf(typeof(HEAPENTRY32));
            if (!Heap32ListFirst(hHeapSnap, ref hl))
            {

                do
                {
           //         UIntPtr x = (UIntPtr)hl.th32HeapID;
                    HEAPENTRY32 he = new HEAPENTRY32();
           //         IntPtr he1 = INVALID_HANDLE_VALUE;
                    //try
                    //{
                    //    ZeroMemory(he, (IntPtr)Marshal.SizeOf(typeof(HEAPENTRY32)));
                    //}
                    //catch (AccessViolationException ex)
                    //{

                    //}
                    he.dwSize = (UIntPtr)Marshal.SizeOf(typeof(HEAPENTRY32));
                    if (Heap32First(ref he, dwPID, hl.th32HeapID))
                    {
                        Console.WriteLine("\n Heap ID "+ hl.th32HeapID);
                        do
                        {
                            Console.WriteLine("Block Size "+ he.dwBlockSize);
                            he.dwSize = (UIntPtr)Marshal.SizeOf(typeof(HEAPENTRY32));
                        } while (Heap32Next(ref he));
                    }
                    hl.dwSize = (UIntPtr)Marshal.SizeOf(typeof(HEAPLIST32));
                } while (Heap32ListNext(hHeapSnap, ref hl));
            }
            else
                Console.WriteLine("CAnnot list heap");

            CloseHandle(hHeapSnap);
            return true;

        }
    }
}
