using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplicationlaba2
{
    public partial class Form1 : Form
    {
        private IAnimal inter;
        Color color;

        int maxSpeed;

        int weight;
        bool uzor;
        Color dopcolor;



        public Form1()
        {
            InitializeComponent();
            color = Color.Black;

            weight = 20;
            maxSpeed = 30;
            button2.BackColor = color;
            dopcolor = Color.Red;
            button4.BackColor = dopcolor;

        }

        private bool checkFields()
        {
            if (!int.TryParse(textBox1.Text, out maxSpeed))
            {
                return false;
            }
            if (!int.TryParse(textBox2.Text, out weight))
            {
                return false;
            }
            return true;
        }




        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            inter = new Spiderswolf(maxSpeed, weight, color);
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics gr = Graphics.FromImage(bmp);
            inter.drawSpiderwolf(gr);
            pictureBox1.Image = bmp;


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (checkFields())
            {
                uzor = true;
                inter = new Tarantul(maxSpeed, weight, color, checkBox1.Checked, dopcolor);
                Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                Graphics gr = Graphics.FromImage(bmp);
                inter.drawSpiderwolf(gr);
                pictureBox1.Image = bmp;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                color = cd.Color;
                button2.BackColor = color;
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                dopcolor = cd.Color;
                button4.BackColor = dopcolor;
            }


        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (inter != null)
            {
                Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                Graphics gr = Graphics.FromImage(bmp);
                inter.moveSpiderwolf(gr);
                pictureBox1.Image = bmp;
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = maxSpeed.ToString();
            textBox2.Text = weight.ToString();

        }
    }
}
