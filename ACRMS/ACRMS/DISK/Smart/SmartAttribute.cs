using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACRMS.DISK.Smart
{
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    public struct SmartAttribute
    {
        public SmartAttributeType AttributeType;
        public ushort Flags;
        public byte Value;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public byte[] VendorData;

        public bool Advisory
        {
            get
            {
                return (this.Flags & 0x1) == 0x0; // Bit 0 unset?
            }
        }

        public bool FailureImminent
        {
            get
            {
                return (this.Flags & 0x1) == 0x1; // Bit 0 set?
            }
        }

        public bool OnlineDataCollection
        {
            get
            {
                return (this.Flags & 0x2) == 0x2; // Bit 0 set?
            }
        }

    }
}
