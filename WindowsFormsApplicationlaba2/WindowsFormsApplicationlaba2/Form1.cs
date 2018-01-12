using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplicationlaba2
{
    public partial class Form1 : Form
    {
        Parking parking;

        public Form1()
        {
            InitializeComponent();
            parking = new Parking();
            Draw();
        }


        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics gr = Graphics.FromImage(bmp);
            parking.Draw(gr, pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = bmp;
        }





        private void button1_Click(object sender, EventArgs e)
        {

            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                var tarantul = new Spiderswolf(30, 5, dialog.Color);

                int place = parking.PutTarantulInShowcase(tarantul);
                Draw();
                MessageBox.Show("Ваше место: " + place);
            }


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }




        private void button3_Click(object sender, EventArgs e)
        {

            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ColorDialog dialogDop = new ColorDialog();
                if (dialogDop.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    var tarantul = new Tarantul(30, 5, dialog.Color, true, dialogDop.Color);
                    int place = parking.PutTarantulInShowcase(tarantul);
                    Draw();
                    MessageBox.Show("Ваше место: " + place);
                }
            }

        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }


        
        

        private void button2_Click(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text != "")
            {
                var car = parking.GetTarantulInShowcase(Convert.ToInt32(maskedTextBox1.Text));

                Bitmap bmp = new Bitmap(pictureBox2.Width, pictureBox2.Height);
                Graphics gr = Graphics.FromImage(bmp);
                car.setPosition(5, 5);
                car.drawSpiderwolf(gr);
                pictureBox2.Image = bmp;
                Draw();
            }
        }
    }
}
