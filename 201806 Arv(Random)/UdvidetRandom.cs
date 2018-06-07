using System;
using System.Timers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _201806_Arv_Random_
{
    class UdvidetRandom : System.Random
    {
        public bool NextBool()
        {
            return this.Next(1, 1002) < 500;
        }
    }

   class time 
    {
        public bool Start()
        {
            Timer t1 = new Timer(10000);
            t1.Start();
            return true;
        }
    }

}
