using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs201806_ArealBeregning
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ArealBeregning.BeregnArealFirkant(10,10));
            Console.WriteLine(ArealBeregning.BeregnArealCircle(10));

            Console.Read();
        }
    }
    class ArealBeregning
    {
        public static double BeregnArealFirkant(double h, double b)
        {
            return h * b;
        }

        public static double BeregnArealCircle(double r)
        {
            return Math.Pow(r, 2) * Math.PI;
        }


    }

}
