using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Reflection;

namespace MyLogger
{
    public sealed class Log
    {
        //public string DebugString { get; set; }

        public static void Info(string infoStr)
        {
            string pathToLog = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Log");
            if (!Directory.Exists(pathToLog))
            {
                Directory.CreateDirectory(pathToLog);
            }
            var count = 0;
            string fileName = Path.Combine(pathToLog, string.Format("log {0:yyyy.mm.dd}_[{1}].txt",
                                                     DateTime.Now, Convert.ToString(count += 1)));
            string fullText = string.Format("[{0:dd.mm.yyy hh:mm:ss.fff}] [{1}.{2}()] {3}\r\n", 
                            DateTime.Now, Assembly.GetExecutingAssembly().EntryPoint.DeclaringType.Namespace,
                            Assembly.GetExecutingAssembly().GetName().Name/*, infoStr.*/);
            File.AppendAllText(fileName, fullText, Encoding.GetEncoding("utf-8"));


        }

        public static void Debug(string debugStr)
        {
            //Console.WriteLine(debugStr);
            
        }

        public static void Error(string errorStr)
        {
            //Console.WriteLine();
        }
    }
}
