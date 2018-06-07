using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs201806_Dyr_Polymorfi
{
    class Program
    {
        static void Main(string[] args)
        {

            Hund H1 = new Hund();
            H1.SigNoget();

            Kat K1 = new Kat();
            K1.SigNoget();

            Dyr[] dyr = new Dyr[20];
            for (int i = 0; i < 20; i++)
            {
                dyr[i] = Dyr.Tilfældigtdyr();
            }
            foreach (var item in dyr)
            {
                item.SigNoget();
            }


            Console.Read();

        }
    }
}
