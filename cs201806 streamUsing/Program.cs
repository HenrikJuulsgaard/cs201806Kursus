using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs201806_streamUsing
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = DateTime.Now;

            Console.WriteLine(dt.ToString("s"));
            try
            {
               
                for (int i = 0; i < 10; i++)
                {

                    System.IO.StreamReader stream = System.IO.File.OpenText(@"x:\dyrenavne.txt");
                    while (stream.Peek() != -1)
                    {
                        String Navn = stream.ReadLine();
                        Console.WriteLine(Navn);
                    }

                    stream.Close();
                    stream = null;
                    
                }


                Console.WriteLine(dt.ToString("HH:mm:ss:fff"));

                Console.Read();
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
