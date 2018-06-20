using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs201806_Delegate_Maskine
{
    public delegate void Log(string txt);
    class Program
    {
        static void Main(string[] args)
        {
            Maskine a = new Maskine();

            a.logger = AppendLog;
            a.logger += Console.WriteLine;
            a.start();
            a.stop();




            


        }




        public static void AppendLog(string txt)
        {
            try
            {

                System.IO.File.AppendAllText(@"c:\temp\log.txt", txt + "\r\n");
            }
            catch (Exception)
            {

                throw;
            }
        }
    }

    class Maskine
    {
        public Log logger { get; set; }

        public void start()
        {
            if (logger != null)
            {
                this.logger(DateTime.Now.ToLongTimeString() + " Starter");
            }
            
        }

        public void stop()
        {
            if (logger != null)
            {
                this.logger(DateTime.Now.ToLongTimeString() + " Stopper");
            }
        }
    }
}
