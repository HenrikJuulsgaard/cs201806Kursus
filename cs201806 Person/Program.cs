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
            Person A = new Person();
            A.Fornavn = "Henrik";
            A.Efternavn = "Juulsgard";
            Console.WriteLine(A.FuldtNavn());

            Elev B = new Elev();
            B.Fornavn = "Bjarne";
            B.Efternavn = "Jensen";
            B.Klasselokale = "No 1";
            Console.WriteLine(B.FuldtNavn());

            Instruktør C = new Instruktør();
            C.Fornavn = "Kurt";
            C.Efternavn = "Thorsen";
            C.NøgleId = 23;
            Console.WriteLine(C.FuldtNavn());




            Console.Read();



        }
    }
}
