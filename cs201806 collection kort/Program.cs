using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs201806_collection_kort
{
    class Program
    {
        static void Main(string[] args)
        {

            Bunke b = new Bunke();

            b.Tilføj(new Kort { Kulør = "spar", Værdi = 8 });
            b.Tilføj(new Kort { Kulør = "spar", Værdi = 7 });
            b.Tilføj(new Kort { Kulør = "hjerter", Værdi = 9 });
            b.Tilføj(new Kort { Kulør = "ruder", Værdi = 8 });

            b.VisKort();

            var k = b.FjernKort();
            Console.WriteLine();
            Console.WriteLine(k);

            Console.Read();
        }
    }


    public class Kort
    {
        public string Kulør { get; set; }
        public int Værdi { get; set; }
        public override string ToString()
        {
            return this.Kulør + " " +this.Værdi;
        }
    }

    public class Bunke
    {
        private Stack<Kort> Korts = new Stack<Kort>();
        public void Tilføj(Kort k)
        {
            this.Korts.Push(k);
        }

        public void VisKort()
        {
            foreach (var item in this.Korts)
            {
                Console.WriteLine(item);
            }
        }
        public Kort FjernKort()
        {
            if (Korts.Count > 0)
            {
                return Korts.Pop();
            }
            return null;
        }
    }
}
