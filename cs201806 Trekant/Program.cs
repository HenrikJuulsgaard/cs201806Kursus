using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs201806_Trekant
{
    class Program
    {
        static void Main(string[] args)
        {

            Trekant T1 = new Trekant(100, 250);
            Console.WriteLine(T1.Areal());



            Console.Read();
        }
    }
}
