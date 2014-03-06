using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace ACRM
{
    /// <summary>
    /// This class can be used to update the main UI using different Threads so that the main UI will stay responsive
    /// </summary>
    public static class ExtensionMethod
    {
        public static TResult SafeInvoke<T, TResult>(this T isi, Func<T, TResult> call) where T : ISynchronizeInvoke
        {
            if (isi.InvokeRequired)
            {
                IAsyncResult result = isi.BeginInvoke(call, new object[] { isi });
                object endResult = isi.EndInvoke(result); return (TResult)endResult;
            }
            else
                return call(isi);
        }

        public static void SafeInvoke<T>(this T isi, Action<T> call) where T : ISynchronizeInvoke
        {
            if (isi.InvokeRequired) isi.BeginInvoke(call, new object[] { isi });
            else
                call(isi);
        }
    }
}
