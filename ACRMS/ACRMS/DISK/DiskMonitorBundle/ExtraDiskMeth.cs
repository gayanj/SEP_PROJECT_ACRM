namespace ACRMS.DISK.DiskMonitorBundle
{
    using System;

    public static class ExtraDiskMeth
    {
        private static readonly string[] SizeSuffixes = { "bytes", "KB", "MB", "GB", "TB", "PB", "EB", "ZB", "YB" };

        public static string SizeSuffix(long value)
        {
            int mag = (int)Math.Log(value, 1024);
            decimal adjustedSize = (decimal)value / (1L << (mag * 10));

            return string.Format("{0:n1} {1}", adjustedSize, SizeSuffixes[mag]);
        }

        public static string SizeSuffix(string strval)
        {
            if (strval == null){
                return "0";
            }
            double value = double.Parse(strval);
            if (value.Equals(0.0))
            {
                return "0";
            }

            int mag = (int)Math.Log(value, 1024);
            double adjustedSize = (double)value / (1L << (mag * 10));
            return string.Format("{0:n1} {1}", adjustedSize, SizeSuffixes[mag]);
        }
    }
}