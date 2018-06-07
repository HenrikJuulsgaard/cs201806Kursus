using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs201806_Costum_Fejlhåndtering
{
    public class StockItem
    {
        public int ID { get; set; }

        public StockItem(int id )
        {
            if (id < 0)
            {
                throw new StockItemException(" Wrong Id");
            }
        }
    }

    public class StockItemException : Exception
    {
        public StockItemException(string message) : base(message) { }
    }
}
