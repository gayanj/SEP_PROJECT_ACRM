using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ACRMS.DISK
{
    public class ExtraDiskMeth
    {
        static readonly string[] SizeSuffixes = { "bytes", "KB", "MB", "GB", "TB", "PB", "EB", "ZB", "YB" };
        public static string SizeSuffix(Int64 value)
        {
            int mag = (int)Math.Log(value, 1024);
            decimal adjustedSize = (decimal)value / (1L << (mag * 10));

            return string.Format("{0:n1} {1}", adjustedSize, SizeSuffixes[mag]);
        }

        public static string SizeSuffix(string strval)
        {
            double value = double.Parse(strval);
            if (value == 0.0)
            {
                return "0";
            }
            else
            {
                int mag = (int)Math.Log(value, 1024);
                double adjustedSize = (double)value / (1L << (mag * 10));

                return string.Format("{0:n1} {1}", adjustedSize, SizeSuffixes[mag]);
            }
        }
    }
}
