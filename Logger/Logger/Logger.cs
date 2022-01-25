using System;
using System.Collections.Generic;

namespace LoggerService
{
    public class Logger
    {
        private static readonly Logger instance = new Logger();

        static Logger()
        {
        }

        private Logger()
        {
        }

        public static Logger Instance
        {
            get
            {
                return instance;
            }
        }       

        public List<string> Logs = new List<string>();

        public void Log(LogType logType, string message)
        {
            var log = DateTime.Now.ToString() + " " + logType + " " + message;
            Logs.Add(log);
            
           // Console.WriteLine(log);
        }
    }
}