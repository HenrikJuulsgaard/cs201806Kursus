using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs201806_Delegate_maskine_func
{
    class Program
    {
        // Delegate , KAN NU UNDVÆRES DA DER ANVENDES FUNC
        // public delegate int Beregn(int a, int b);    

        static void Main(string[] args)
        {
            int res = Beregner(1, 2, Plus);

            Console.WriteLine(res);

            res = Beregner(1, 2, Minus);
            Console.WriteLine(res);


            res = Beregner(1, 2, Gange);
            Console.WriteLine(res);

            res = Beregner(1, 2, Divider);
            Console.WriteLine(res);

            var f = FindTilfældigFunktion();
            res = f(2, 2);
            Console.WriteLine(res);


            Console.Read();

        }

        // Brug funktion til beregning
        public static int Beregner(int a, int b, Func<int, int,int> fun)
        {
            return fun(a, b);
        }

        // Find funktion
        public static Func<int,int,int> FindTilfældigFunktion()
        {

            if ((DateTime.Now.Millisecond)%2== 1)
            {
                return Plus;
            }
            return Minus;
        }

        // Plus metode
        public static int Plus(int a, int b)
        {
            return a + b;
        }

        // Minus metode
        public static int Minus(int a, int b)
        {
            return a - b;
        }

        // Divider metode
        public static int Divider(int a, int b)
        {
            return a / b;
        }

        // Minus metode
        public static int Gange(int a, int b)
        {
            return a * b;
        }

    }
}
