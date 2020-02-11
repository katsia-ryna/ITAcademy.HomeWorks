using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Reflection;

namespace MyLogger
{
    public delegate void LogDelegate (string message);
    public sealed class Log
    {
        
        public static void Info(string infoStr)
        {
            /*StreamWriter sw;
            FileInfo logFile = new FileInfo(@"D:\Катя+++\1hw\ITAcademy.HomeWorks\Project.Shop.Bike_Components\Project.Shop.Bike_Components\bin\Debug\netcoreapp3.0\log.txt");
            long fileByteSize = logFile.Length;
            if (fileByteSize >= 30000)
            {
                File.CreateNew(@"D:\Катя+++\1hw\ITAcademy.HomeWorks\Project.
                Shop.Bike_Components\Project.Shop.Bike_Components\bin\Debug\netcoreapp3.0\log.txt", 30_000);
            }
            sw = logFile.AppendText();
            sw.WriteLine(infoStr);
            sw.Close();*/

            string pathToLog = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Log");
            if (!Directory.Exists(pathToLog))
            {
                Directory.CreateDirectory(pathToLog);
            }

            var count = 0;
            string fileName = Path.Combine(pathToLog, String.Format("log {0:yyyy.mm.dd}_[{1}].txt",
                                                     DateTime.Now, Convert.ToString(count += 1)));
            string fullText = String.Format("[{0:dd.mm.yyyy hh:mm:ss.fff}] [{1}.{2}()] \r\n", 
                            DateTime.Now, Assembly.GetExecutingAssembly().EntryPoint.DeclaringType.Namespace,
                            Assembly.GetExecutingAssembly().GetName().Name, infoStr);
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
