using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs201806_Costum_Fejlhåndtering
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                StockItem Item1 = new StockItem(7);
                Item1.ID = -7;

            }
            catch (StockItemException ex)
            {
                Console.WriteLine(" Stock Item error ");
               
            }
            catch (Exception)
            {
                Console.WriteLine(" General error ");
            }

            Console.Read();
        }
    }
}
