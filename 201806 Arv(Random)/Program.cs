using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _201806_Arv_Random_
{
    class Program
    {
        static void Main(string[] args)
        {
            UdvidetRandom e = new UdvidetRandom();
            Console.WriteLine(e.NextBool());

            Console.Read();

            time t1 = new time();
            t1.Start();

        }

    }
}
