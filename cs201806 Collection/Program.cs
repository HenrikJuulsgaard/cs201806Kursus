using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs201806_Collection
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Person> ts = new List<Person>();

            ts.Add(new Person() { Id = 1, Navn = "Jørgen" });
            ts.Add(new Person() { Id = 2, Navn = "Else" });
            ts.Add(new Person() { Id = 8, Navn = "Kaj" });
            foreach (var item in ts)
            {
                Console.WriteLine("Id: " + item.Id.ToString() + " Navn: " + item.Navn);
            }

          



            Dictionary<int, Person> lst = new Dictionary<int, Person>();

            lst.Add(1, ts[0]);
            lst.Add(2, ts[1]);
            lst.Add(3, ts[2]);

            var p = lst[3];
            Console.WriteLine(p.Navn);



            Console.Read();
        }

        class Person
        {
            public int Id { get; set; }
            public string Navn { get; set; }

        }
    }
}
