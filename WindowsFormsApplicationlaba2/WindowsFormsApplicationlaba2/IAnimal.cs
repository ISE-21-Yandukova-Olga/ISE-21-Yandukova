using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplicationlaba2
{
    interface IAnimal
    {
        void moveSpiderwolf(Graphics g);
        void drawSpiderwolf(Graphics g);
        void setPosition(int x, int y);
    }

}
