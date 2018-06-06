using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs201806Kursus
{
    class Terning
    {
        public int værdi;
        private bool snyd;
        private static Random rnd = new Random();
        private int Skriv()
        {
            return 2;
        }
        private int Ryst()
        {
            int tal;
            if (!snyd)
            {
                tal = rnd.Next(1, 7);
            }
            else
            {
                tal = 6;
            }
            return tal;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
