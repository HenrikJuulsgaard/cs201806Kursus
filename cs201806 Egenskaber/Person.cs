using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs201806_Egenskaber
{
    class Person
    {
        public string Fornavn { get; set; }

        private string _Efternavn;

        public string EfterNavn
        {
            get { return _Efternavn; }
            set {
                if (value.Length > 3)
                    _Efternavn = value;
                else
                    _Efternavn = Environment.NewLine + "*** Value to short ***";
            }
        }

        public string FuldtNavn()
        {
            return (this.Fornavn + " " + this._Efternavn);
        }

    }
}
