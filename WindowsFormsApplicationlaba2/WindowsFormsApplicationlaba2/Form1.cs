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
        Parking parking;
        Form2 form;
        public Form1()
        {
            InitializeComponent();
            parking = new Parking(5);
            for (int i = 1; i < 6; i++)
            {
                listBox1.Items.Add("Уровень " + i);
            }
            listBox1.SelectedIndex = parking.getCurrentLevel;
            Draw();
        }
        private void Draw()
        {
            if (listBox1.SelectedIndex > -1)
            {
                Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                Graphics gr = Graphics.FromImage(bmp);
                parking.Draw(gr);
                pictureBox1.Image = bmp;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
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

        private void button4_Click(object sender, EventArgs e)
        {
            form = new Form2();
            form.AddIAnimal(AddSpider);
            form.Show();
        }
        public void AddSpider(IAnimal ianimal)
        {
            if (ianimal != null)
            {
                int place = parking.PutTarantulInShowcase(ianimal);
                if (place > -1)
                {
                    Draw();
                    MessageBox.Show("Ваше место:" + place);
                }
                else MessageBox.Show("Не удалось задать паука");
            }
        }


        private void button5_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > -1)
            {
                string level = listBox1.Items[listBox1.SelectedIndex].ToString();

                if (maskedTextBox1.Text != "")
                {
                    IAnimal ianimal = parking.PutTarantulInShowcase(Convert.ToInt32(maskedTextBox1.Text));
                    if (ianimal != null)
                    {
                        Bitmap bmp = new Bitmap(pictureBox2.Width, pictureBox2.Height);
                        Graphics gr = Graphics.FromImage(bmp);
                        ianimal.setPosition(5, 5);
                        ianimal.drawSpiderwolf(gr);
                        pictureBox2.Image = bmp;
                        Draw();
                    }
                    else
                    {
                        MessageBox.Show("Извините, на этом месте нет паука");
                    }

                }

            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}

