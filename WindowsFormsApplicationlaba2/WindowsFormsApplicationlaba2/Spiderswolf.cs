using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplicationlaba2
{
    class Spiderswolf : Arthropods
    {
        public override int MaxSpeed
        {
            get
            {
                return base.MaxSpeed;
            }

            protected set
            {
                if (value > 0 && value < 100)

                {
                    base.MaxSpeed = value;
                }
                else
                {
                    base.MaxSpeed = 30;
                }
            }
        }
        public override double Weight
        {
            get
            {
                return base.Weight;
            }
            protected set
            {
                if (value > 10 && value < 30)
                {
                    base.Weight = value;
                }
                else
                {
                    base.Weight = 20;
                }
            }
        }

        public Spiderswolf(int maxSpeed, double weight, Color color)
        {
            this.MaxSpeed = maxSpeed;
            this.ColorBody = color;
            this.Weight = weight;

            //Random rand = new Random();
            startPosX = 0;
            startPosY = 0;

        }
        public Spiderswolf(string info)
        {
            string[] strs = info.Split(';');
            if (strs.Length == 3)
            {
                Weight = Convert.ToInt32(strs[0]);
                MaxSpeed = Convert.ToInt32(strs[1]);
                ColorBody = Color.FromName(strs[2]);
            }
            Random rand = new Random();
            startPosX = rand.Next(10, 200);
            startPosY = rand.Next(10, 200);
        }
        public override void drawSpiderwolf(Graphics g)
        {
            drawSpider(g);
        }



        protected virtual void drawSpider(Graphics g)
        {

            Brush brush = new SolidBrush(ColorBody);
            g.FillEllipse(brush, startPosX + 50, startPosY + 10, 30, 30);
            g.FillEllipse(brush, startPosX + 45, startPosY + 30, 40, 40);
            Pen pen = new Pen(ColorBody);
            g.DrawLine(pen, startPosX + 35, startPosY + 30, startPosX + 50, startPosY + 40);
            g.DrawLine(pen, startPosX + 30, startPosY + 45, startPosX + 50, startPosY + 50);
            g.DrawLine(pen, startPosX + 35, startPosY + 65, startPosX + 50, startPosY + 60);
            g.DrawLine(pen, startPosX + 25, startPosY + 40, startPosX + 35, startPosY + 30);
            g.DrawLine(pen, startPosX + 20, startPosY + 55, startPosX + 30, startPosY + 45);
            g.DrawLine(pen, startPosX + 25, startPosY + 80, startPosX + 35, startPosY + 65);
            g.DrawLine(pen, startPosX + 40, startPosY + 17, startPosX + 53, startPosY + 31);
            g.DrawLine(pen, startPosX + 50, startPosY + 7, startPosX + 40, startPosY + 17);
            g.DrawLine(pen, startPosX + 75, startPosY + 34, startPosX + 95, startPosY + 17);
            g.DrawLine(pen, startPosX + 80, startPosY + 40, startPosX + 95, startPosY + 30);
            g.DrawLine(pen, startPosX + 95, startPosY + 17, startPosX + 85, startPosY + 7);
            g.DrawLine(pen, startPosX + 95, startPosY + 30, startPosX + 105, startPosY + 42);
            g.DrawLine(pen, startPosX + 80, startPosY + 53, startPosX + 100, startPosY + 47);
            g.DrawLine(pen, startPosX + 100, startPosY + 47, startPosX + 110, startPosY + 55);
            g.DrawLine(pen, startPosX + 80, startPosY + 60, startPosX + 96, startPosY + 65);
            g.DrawLine(pen, startPosX + 96, startPosY + 65, startPosX + 103, startPosY + 80);

        }

        public override void moveSpiderwolf(Graphics g)
        {
            startPosX += MaxSpeed * 50 / (float)Weight;
            drawSpiderwolf(g);
        }
        public override string getInfo()
        {
            return Weight + ";" + MaxSpeed + ";" + ColorBody.Name;
        }
    }
}





