using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursus.Kortspil.Kerne
{
    public class Kort
    {
        public int Værdi { get; private set; }
        public KortKulør Kulør;
        private static System.Random rnd;

        static Kort()
        {
            rnd = new Random();
        }

        public Kort()
        {
            this.Værdi = rnd.Next(2, 15);
        }

        public Kort(int værdi)
        {
            this.Værdi = rnd.Next(2, 15);
            this.Kulør = (KortKulør) rnd.Next(0, 4);
        }

    }
}
