using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Reflection;
using log4net;
using log4net.Config;

namespace HW11.Task1
{
    class Logger
    {
        public static ILog Log { get; } = LogManager.GetLogger(typeof(Logger));
        public static void InitLogger()
        {
            var logRepository = LogManager.GetRepository(Assembly.GetEntryAssembly());
            XmlConfigurator.Configure(logRepository, new FileInfo("Log.config"));
        }
    }
}
