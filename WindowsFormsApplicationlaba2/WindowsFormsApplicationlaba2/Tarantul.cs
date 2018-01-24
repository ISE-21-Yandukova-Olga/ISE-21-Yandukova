using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplicationlaba2
{
    class Tarantul : Spiderswolf, IComparable<Tarantul>, IEquatable<Tarantul>
    {
        private Color dopcolor;
        private bool uzor;


        public Tarantul(int maxSpeed, double weight, Color color, bool uzor, Color dopcolor) :
            base(maxSpeed, weight, color)
        {
            this.dopcolor = dopcolor;
            this.uzor = uzor;


        }
        public Tarantul(string info) : base(info)
        {
            string[] strs = info.Split(';');
            if (strs.Length == 5)
            {
                Weight = Convert.ToInt32(strs[0]);
                MaxSpeed = Convert.ToInt32(strs[1]);

                ColorBody = Color.FromName(strs[2]);
                uzor = Convert.ToBoolean(strs[3]);
                dopcolor = Color.FromName(strs[4]);
            }
        }

        protected override void drawSpider(Graphics g)
        {
            base.drawSpider(g);
            if (uzor)
            {


                Pen pe = new Pen(dopcolor);
                g.DrawEllipse(pe, startPosX + 50, startPosY + 35, 30, 30);
                g.DrawEllipse(pe, startPosX + 55, startPosY + 40, 20, 20);
                g.DrawEllipse(pe, startPosX + 60, startPosY + 45, 10, 10);

                Brush br = new SolidBrush(dopcolor);
                g.FillEllipse(br, startPosX + 55, startPosY + 12, 10, 10);
                g.FillEllipse(br, startPosX + 65, startPosY + 12, 10, 10);

            }
        }

        public void setDopColor(Color color)
        {
            dopcolor = color;
        }
        public override string getInfo()
        {
            return Weight + ";" + MaxSpeed + ";" + ColorBody.Name + ";" + uzor + ";" + dopcolor.Name;
        }
        public int CompareTo(Tarantul other)
        {
            var res = (this is Spiderswolf).CompareTo(other is Spiderswolf);
            if (res != 0)
            {
                return res;
            }
            if (uzor != other.uzor)
            {
                return uzor.CompareTo(other.uzor);
            }
            if (dopcolor != other.dopcolor)
            {
                return dopcolor.Name.CompareTo(other.dopcolor.Name);
            }
            return 0;
        }

        public bool Equals(Tarantul other)
        {
            var res = (this is Spiderswolf).Equals(other is Spiderswolf);
            if (!res)
            {
                return res;
            }
            if (uzor != other.uzor)
            {
                return false;
            }
            if (dopcolor != other.dopcolor)
            {
                return false;
            }
            return true;
        }
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;

            }
            Tarantul TarantulObj = obj as Tarantul;
            if (TarantulObj == null)
            {
                return false;
            }
            else
            {
                return Equals(TarantulObj);
            }
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}





