using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplicationlaba2
{
    class Tarantul : Spiderswolf
    {
        private Color dopcolor;
        private bool uzor;


        public Tarantul(int maxSpeed, double weight, Color color, bool uzor, Color dopcolor) :
            base(maxSpeed, weight, color)
        {
            this.dopcolor = dopcolor;
            this.uzor = uzor;


        }

        protected override void drawSpider(Graphics g)
        {
            base.drawSpider(g);
            if (uzor)
            {


                Pen pe = new Pen(dopcolor);
                g.DrawEllipse(pe, startPosX + 50, startPosY + 35,  30,  30);
                g.DrawEllipse(pe, startPosX + 55, startPosY + 40, 20,  20);
                g.DrawEllipse(pe, startPosX + 60, startPosY + 45,  10, 10);

                Brush br = new SolidBrush(dopcolor);
                g.FillEllipse(br, startPosX + 55, startPosY + 12, 10, 10);
                g.FillEllipse(br, startPosX + 65, startPosY + 12, 10, 10);

            }

        }
    }
}




