using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs201806_Dyr_Polymorfi
{
    abstract class Dyr
    {
        static System.Random rnd = new Random();
        public string Navn { get; set; }

        public virtual void SigNoget()
        {
            Console.WriteLine("Jeg er et dyr der hedder sofus");
        }

        public static Dyr Tilfældigtdyr()
        {
            string[] S = System.IO.File.ReadAllLines(@"x:\dyrenavne.txt");
            int index = rnd.Next(0, S.Length);

            if (index % 2 == 0)
            {
                return new Hund() { Navn = S[index] };
            }
            else
            {
                return new Kat() { Navn = S[index] };
            }
        }
        
    }

    class Hund : Dyr
    {
        public override void SigNoget()
        {
            Console.WriteLine("Jeg er en hund der hedder " + Navn);
        }
    }

    class Kat : Dyr
    {
        public override void SigNoget()
        {
            Console.WriteLine("Jeg er en kat der hedder " + Navn);
        }


    }

}
