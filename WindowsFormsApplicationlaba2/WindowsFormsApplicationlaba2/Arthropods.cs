using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplicationlaba2
{
    public abstract class Arthropods : IAnimal
    {
        protected float startPosX;

        protected float startPosY;

        public virtual int MaxSpeed { protected set; get; }

        public System.Drawing.Color ColorBody { protected set; get; }

        public virtual double Weight { protected set; get; }

        public virtual int Paw { protected set; get; }


        public abstract void drawSpiderwolf(Graphics g);


        public abstract void moveSpiderwolf(Graphics g);
        public virtual void setMainColor(Color color)
        {
            ColorBody = color;
        }


        public void setPosition(int x, int y)
        {
            startPosX = x;
            startPosY = y;
        }

    }

}







