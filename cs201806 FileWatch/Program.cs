using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs201806_FileWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            // New filewatcher
            System.IO.FileSystemWatcher w = new System.IO.FileSystemWatcher(@"c:\temp", "*.txt");
            // Enable watcher
            w.EnableRaisingEvents = true;
            //w.Changed += W_Changed;
            w.Changed += (s, e) => { Console.WriteLine("file changed:" + e.Name); };

            do
            {

            } while (true);
           
        }

        private static void W_Changed(object sender, System.IO.FileSystemEventArgs e)
        {
            Console.WriteLine("file change");
        }
    }



}
