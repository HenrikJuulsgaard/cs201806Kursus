using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs201806_Egenskaber
{
    class Program
    {
        static void Main(string[] args)
        {
            Vare v = new Vare();
            v.Navn = " Vare #1 ";
            v.Pris = 100;
            Console.WriteLine(v.PrisMedMoms());
            Vare v2 = new Vare("vare #2" , 200 );
            Console.WriteLine(v2.PrisMedMoms());


            Person p1 = new Person();
            p1.Fornavn = "Henrik";
            p1.EfterNavn = "Ju";
            Console.WriteLine(p1.FuldtNavn());

            Console.Read();

        }
    }

    class Vare
    {
        // Constructor
        public Vare()
        {
        }


        // Constructor
        public Vare(string Navn, double Pris)
        {
            this._Navn = Navn;
            this._Pris = Pris;
        }

        private string _Navn;
        public string Navn
        {
            get {
                Console.WriteLine(_Navn + " Get navn ");
                return _Navn; }
            set {
                _Navn = value;
                Console.WriteLine(_Navn + " Set navn ");
            }
        }

        private Double _Pris;

        public Double Pris
        {
            get {
                Console.WriteLine(_Pris.ToString() + " Get pris ");
                return _Pris; }
            set {
                _Pris = value;
                Console.WriteLine(_Pris.ToString() + " Set navn ");
            }
        }
        public double PrisMedMoms()
        {
            return this._Pris * 1.25;
        }
    }
}
