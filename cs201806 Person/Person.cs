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



    }

    class Elev : Person
    {
        public string Klasselokale { get; set; }

    }

    class Instruktør : Person
    {
        public int NøgleId { get; set; }

    }

}
