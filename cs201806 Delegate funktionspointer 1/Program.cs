using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs201806_Delegate_funktionspointer_1
{
    class Program
    {
        // Delegate
        public delegate int Beregn (int a, int b); 

        static void Main(string[] args)
        {
            Beregn s = new Beregn(Plus);
            int res = Beregner(1, 2,s);

            Console.WriteLine(res);

            s += Minus;
            res = Beregner(1, 2, s);
            Console.WriteLine(res);


            s += Gange;
            res = Beregner(1, 2, s);
            Console.WriteLine(res);

            s += Gange;
            s += Gange;
            s += Divider;
            res = Beregner(1, 2, s);
            Console.WriteLine(res);


            Console.Read();

        }

        // Brug funktion
        public static int Beregner(int a,int b , Beregn fun)
        {
            return fun(a, b);
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
