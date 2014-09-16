using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace WebSockets.Logging
{
    public class FileLogger
    {
        // For thread synchronization
        private static readonly object _syncObject = new object();
        private static TextWriter tw; 

        private static FileLogger _instance;

        private static string InstanceID;

        /// <summary>
        /// Return the singleton instance of the File Logger. 
        /// </summary>
        public static FileLogger Instance
        {
            get {
                if (_instance == null)
                    _instance = new FileLogger();
                return _instance;
            }
        }

        private FileLogger()
        {                    
            string LogFolder = Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetCallingAssembly().Location), "Logs");
            
            if (!Directory.Exists(LogFolder))
                Directory.CreateDirectory(LogFolder);

            TimeSpan t = DateTime.UtcNow - new DateTime(1970, 1, 1);   
            string FilePath = Path.Combine(LogFolder, "WebsocketLogger-" + (long)t.TotalMilliseconds + ".txt");
            tw = TextWriter.Synchronized(File.AppendText(FilePath));

            InstanceID = Guid.NewGuid().ToString();
            LogMessage("Starting New Log.");            
        }

        ~FileLogger()
        {
            //if (tw != null)
            //    tw.Close();
        }

        /// <summary>
        /// Log a message to file
        /// </summary>
        /// <param name="logMessage">Message to log.</param>
        public void LogMessage(string logMessage)
        {
            try
            {
                TimeSpan t = DateTime.UtcNow - new DateTime(1970, 1, 1);
                string msg = (long)t.TotalMilliseconds + " - " + InstanceID + " : " + logMessage;

                Write(msg, tw);
            }
            catch (IOException e)
            {
                //tw.Close();
                //_instance = null;

                //Instance.LogMessage(logMessage);
            }
        }

        /// <summary>
        /// Log Exception details to file.
        /// </summary>
        /// <param name="ex">Exception type object with the details to log.</param>
        public void LogException(Exception exception)
        {
            try
            {
                TimeSpan t = DateTime.UtcNow - new DateTime(1970, 1, 1);
                string msg = (long)t.TotalMilliseconds + " - " + InstanceID + " : " + exception.Message + "\n" + exception.StackTrace;

                Write(msg, tw);
            }
            catch (IOException e)
            {
                //tw.Close();
                //_instance = null;

                //Instance.LogException(exception);
            }
        }

        private void Write(string logMessage, TextWriter w)
        {
            lock (_syncObject)
            {
                w.WriteLine(logMessage);
                w.Flush();
            }
        }
    }
}
