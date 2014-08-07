using System;
using System.Threading;

namespace Network
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
                double seconds = DateTime.Now.Subtract(StartTime).TotalSeconds;
                if ((seconds > _timeout) && SessionTimeout != null)
                {
                    SessionTimeout(this, EventArgs.Empty);
                    oThread.Abort();
                }
                Thread.Sleep(10);
            }
        }
    }
}
