using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pryanik
{
    class plate
    {
        private egg egg;

        private flour flour;

        private cocoa cocoa;

        private butter butter;

        private suger suger;


        public void Addegg(egg e)

        {
            egg = e;
            
        }
        // Добавление сахара в миску 
        public void AddSugar(suger s)
        {
            suger = s;
        }

        // Добавление муки в миску 
        public void AddFlour(flour f)
        {
            flour = f;
        }
        // Добавление какао в миску 

        public void AddCocoa(cocoa c)
        {
            cocoa = c;
        }
        // Добавление масла в миску 
        public void AddButter(butter b)
        {
            butter = b;
        }
        private int has_ready = 0;
        public int Has_ready { get {return has_ready; } }
        public void GetHeat()
        {
            if(has_ready<10)
            {
                has_ready++;
            }
        }

        //Проверка вхождения ингредиентов в миску 
        public bool Check()
        {
            if (egg == null)
            {
                return false;
            }
            if (suger == null)
            {
                return false;
            }
            if (flour == null)
            {
                return false;
            }
            if (butter == null)
            {
                return false;

            }
            if (cocoa == null)
            {
                return false;
            }
            return true;
        }
    }
}

