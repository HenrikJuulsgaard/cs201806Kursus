using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs201806_Generisk_metode
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = 10;
            int b = 11;

            Swap<int>(ref a, ref b);

            Console.Read();
        }

        public static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
    }
}
