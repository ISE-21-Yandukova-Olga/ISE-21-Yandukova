using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pryanik
{
    class air
    {
        private int temper = 25;
        public int Temper { get { return temper; } }
        public void GetHeat()
        {
            if (temper < 240)
            {
                temper++;
            }
        }
        

        


    }
}
