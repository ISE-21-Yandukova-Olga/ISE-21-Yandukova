using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pryanik
{
    class oven
    {
        private plate Plate;
        private air Air;
        

        public void GetHeat()
        {
            Air = new air();
            Plate = new plate();
            
            if (Air.Temper < 240)
            {
                while (Air.Temper != 240)
                {
                    Air.GetHeat();
                }
                while (Plate.Has_ready != 10)
                {
                    Plate.GetHeat();
                }
                
            }
        }
            public bool IsReady()
        {
            if(Air.Temper < 240)
            {
                return false;
            }
            if(Plate.Has_ready < 10)
            {
                return false;
            }
            return true;
        }

    }
}
