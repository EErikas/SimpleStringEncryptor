using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SimpleStringEncryptor.Classes
{
    public class Log
    {
        public struct LogItems
        {
            internal string actionTime { get; set; }
            internal string actionName { get; set; }
            internal string actionDescription { get; set; }
        }

        List<LogItems> logData = new List<LogItems>();

        public void AddLogEntry(string action, string description)
        {
            DateTime dt = DateTime.Now;
            LogItems temp = new LogItems { actionTime = dt.ToShortDateString() + "-" + dt.ToShortTimeString() };
            temp.actionName = action;
            temp.actionDescription = description;
            logData.Add(temp);
        }

        public void SaveLogFile()
        {
            string logFile = @"ActionLog.txt";
            if (!File.Exists(logFile))
            {
                AddLogEntry("Log file created", "New log file created");

                using (StreamWriter logOutputFile = new StreamWriter(logFile))
                {
                    foreach (LogItems logEntry in logData)
                    {
                        logOutputFile.WriteLine(logEntry.actionTime + "-" + logEntry.actionName + "-" + logEntry.actionDescription);
                    }
                }
            }
            else
            {
                using (StreamWriter logOutputFile = File.AppendText(logFile))
                {
                    foreach (LogItems logEntry in logData)
                    {
                        logOutputFile.WriteLine(logEntry.actionTime + "-" + logEntry.actionName + "-" + logEntry.actionDescription);
                    }
                }
            }
        }
        
    }
}



