using System;
using System.Threading;

namespace NativeWrapper.Handlers
{
    internal class TimeoutHandler
    {
        public event EventHandler SessionTimeout;

        private DateTime StartTime;
        private int _timeout;
        private Thread oThread;

        public TimeoutHandler(int Timeout)
        {
            _timeout = Timeout;
            StartTime = DateTime.Now;

            oThread = new Thread(new ThreadStart(Run));
            oThread.Start();
        }

        public void Run()
        {
            while (true)
            {
                if ((DateTime.Now.Subtract(StartTime).TotalMinutes > _timeout) && SessionTimeout != null)
                    SessionTimeout(this, EventArgs.Empty);
                Thread.Sleep(1000);
            }
        }
    }
}
