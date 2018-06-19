using System;
using NLog;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrugAfNlog
{
    class Program
    {

        private static Logger logger = LogManager.GetCurrentClassLogger();
        static void Main(string[] args)
        {
            logger.Trace("enter");


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
