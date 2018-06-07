using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs201806_Person
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person() {Fornavn= "Hans", Efternavn="Petersen"};
            Person e = new Elev() { Fornavn = "Thomas", Efternavn = "Kjeldsen", Klasselokale = "Lokale 1" };
            Person i = new Instruktør() { Fornavn = "Ib", Efternavn = "Nielsen", NøgleId = 258 };

            Person[] lst = new Person[3];
            lst[0] = p;
            lst[1] = e;
            lst[2] = i;


            foreach (var item in lst)
            {
                item.Skriv(item.FuldtNavn());
            }


            Console.Read();



        }
    }
}
