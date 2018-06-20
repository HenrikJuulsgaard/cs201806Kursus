using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs201806_Lambda
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> a = new List<int>() { 5, 6, 8, 7, 9, 6, 2, 5, 4, 5, 6, 8, 4, 1, 2, 3, 1, 0, 8, 7, 4, 9, 8, 7 };
            Console.WriteLine(a.FindIndex(Find));
            Console.WriteLine(a.FindIndex((i)=> { return i == 8; }));  // almindelig lambda

            Console.WriteLine(a.FindIndex(i => i == 8));

            Console.WriteLine();
            a.ForEach(Listværdi);
            Console.WriteLine();
            a.ForEach(i => { Console.WriteLine(i); });
           
        }
        static bool Find(int a)
        {
            if (a < 5)
                return true;
            return false;
        }

        static void Listværdi(int i)
        {
            Console.WriteLine(i);
        }
    }
}
