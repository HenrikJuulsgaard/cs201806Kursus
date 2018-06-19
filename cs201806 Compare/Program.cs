using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs201806_Compare
{
    class Program
    {
        static void Main(string[] args)
        {
            Hund[] hunde = new Hund[6];
            hunde[0] = new Hund { Alder = 8, Navn = "Bulder1" };
            hunde[1] = new Hund { Alder = 5, Navn = "Lady1" };
            hunde[2] = new Hund { Alder = 10, Navn = "Bulder2" };
            hunde[3] = new Hund { Alder = 4, Navn = "Lady2" };
            hunde[4] = new Hund { Alder = 9, Navn = "Bulder3" };
            hunde[5] = new Hund { Alder = 5, Navn = "Lady3" };

            Array.Sort(hunde);
            foreach (var item in hunde)
            {
                Console.WriteLine(item.Navn);
            }

            Console.Read();
        }
    }

    class Hund : IComparable
    {
        public string Navn { get; set; }
        public int Alder { get; set; }

        public int CompareTo(object obj)
        {
            Hund h = obj as Hund;
            if (h.Alder > this.Alder)
                return -1;
            if (h.Alder < this.Alder)
                return 1;
            return 0;
        }
    }
}
