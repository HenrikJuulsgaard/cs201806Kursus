using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs201806_Person
{
    class Person
    {
        // Property
        public string Fornavn { get; set; }
        public string Efternavn { get; set; }

        // Metode
        public string FuldtNavn()
        {
            return (Fornavn + " " + Efternavn);
        }

        public virtual void Skriv(string FuldtNavn)
        {
            Console.WriteLine(FuldtNavn);
        }

    }

    class Elev : Person
    {
        public string Klasselokale { get; set; }
        public override void Skriv(string FuldtNavn)
        {
            Console.WriteLine(FuldtNavn + " " + Klasselokale );
        }

    }

    class Instruktør : Person
    {
        public int NøgleId { get; set; }
        public override void Skriv(string FuldtNavn)
        {
            Console.WriteLine(FuldtNavn + " " + NøgleId);
        }

    }

}
