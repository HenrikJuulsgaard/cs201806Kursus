using System;
using NLog;
using NLog.Config;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrugAfNlog
{
    class Program
    {

        private static Logger logger = LogManager.GetCurrentClassLogger();
        private static readonly string fileName = "SysLog";

        static void Main(string[] args)
        {
            logger.Trace("enter");
            logger.Debug("Nu kaldes test 1");
            test1(84,12);
            test2();

            Console.WriteLine();

            // Tester med ny log fil

            LoggingConfiguration config = LogManager.Configuration;

            var logFile = new NLog.Targets.FileTarget();
            config.AddTarget("file", logFile);
            logFile.FileName = fileName + ".log";
            logFile.Layout = "${date} | ${message}";

            var rule = new LoggingRule("*", LogLevel.Info, logFile);
            config.LoggingRules.Add(rule);

            LogManager.Configuration = config;
            logger.Info("File configuration converted!");


            // *********************


            logger.Trace("enter");
            logger.Debug("Nu kaldes test 1");


            Console.Read();
        }

        static void test1(int i, int x)
        {
            Console.WriteLine("Test1");
            System.Threading.Thread.Sleep(1000);
        }

        static void test2()
        {
            try
            {
                Console.WriteLine("test2");
                throw new ApplicationException("fejl");
            }
            catch(Exception ex)
            {
                logger.Error(ex);
            }
            logger.Trace("exit");
        }   
            




    }
}
