using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs201806_Terning
{
    class Program
    {
        static void Main(string[] args)
        {
            Terning T1 = new Terning();
            T1.Skriv();
            
            Console.Read();
        }
    }

    class Terning
    {
        private static System.Random rnd = new Random();
        private int _Værdi;

        public int Værdi
        {
            get { return _Værdi; }
            private set {
                if (value > 0 & value < 7)
                    _Værdi = value;
                else
                    _Værdi = 1;
            }
        }

        public int Ryst()
        {
            return rnd.Next(1, 7);
        }

        public void Skriv()
        {
            Console.WriteLine("[" + this.Ryst() + "]" );
        }
    }
}
