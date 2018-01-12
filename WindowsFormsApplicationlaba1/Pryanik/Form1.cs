using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pryanik
{
    public partial class Form1 : Form
    {
        private egg[] Egg;
        private knife Knife;
        private plate Plate;
        private flour Flour;
        private cocoa Cocoa;
        private butter Butter;
        private suger Suger;
        private oven Oven;
        private air Air;
        
       
        public Form1()
        {
            InitializeComponent();
        }
        
    private void Form1_Load(object sender, EventArgs e)
        {
            Knife = new knife();
            Plate = new plate();
            Oven = new oven();
            Air = new air();



        }

        private void button1_Click(object sender, EventArgs e)
        {
            
             Egg= new egg[Convert.ToInt32(numericUpDown1.Value)];
            
            
          if(Egg.Length == 0)
            {
                MessageBox.Show("яиц нет", "Ошибка логики");
                return;
            }
            for (int i = 0; i < Egg.Length; i++)
            {

                Egg[i] = new egg();
                Egg[i].Have_skin = true;

            }

           
            for (int i=0; i<Egg.Length;i++)
            {
                Knife.Clean(Egg[i]);
            }
            
            numericUpDown1.Enabled = false;
            button2.Enabled = true;
            button1.Enabled = false;
            
            MessageBox.Show("Яйца разбили!", "Пряник", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Flour = new flour();
            Flour.count = Convert.ToInt32(numericUpDown2.Value);
            if(Flour.count == 0)
            {
                MessageBox.Show("муки нет","Ошибка логики");
                return;
            }
            else
            {
                Plate.AddFlour(Flour);
                MessageBox.Show("Мука в тарелке","Пряник");
            }
            numericUpDown2.Enabled = false;
            button3.Enabled = false;
            progressBar1.Increment(+20);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Cocoa = new cocoa();
            Cocoa.Count_Cocoa= Convert.ToInt32(numericUpDown3.Value);
            if (Cocoa.Count_Cocoa == 0)
            {
                MessageBox.Show("Какао нет", "Ошибка логики");
                return;
            }
            else
            {
                Plate.AddCocoa(Cocoa);
                MessageBox.Show("Какао в тарелке", "Пряник");
            }
            numericUpDown3.Enabled = false;
            progressBar1.Increment(+20);
            button4.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Butter = new butter();
            Butter.Count_Butter = Convert.ToInt32(numericUpDown4.Value);
            if (Butter.Count_Butter == 0)
            {
                MessageBox.Show("Масла нет", "Ошибка логики");
                return;
            }
            else
            {
                Plate.AddButter(Butter);
                MessageBox.Show("Масло в тарелке", "Пряник");
            }
            numericUpDown4.Enabled = false;
            progressBar1.Increment(+20);
            button5.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Suger = new suger();
            Suger.Count_Sugar = Convert.ToInt32(numericUpDown5.Value);
            if (Suger.Count_Sugar == 0)
            {
                MessageBox.Show("Сахара нет", "Ошибка логики");
                return;
            }
            else
            {
                Plate.AddSugar(Suger);
                MessageBox.Show("Сахар в тарелке", "Пряник");
            }
            numericUpDown5.Enabled = false;
            progressBar1.Increment(+20);
            button6.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
                for (int i = 0; i < Egg.Length; i++)
                {
                    Plate.Addegg(Egg[i]);
                }
                MessageBox.Show("Яйца в тарелке","Пряник");
            
            progressBar1.Increment(+20);
            button2.Enabled = false;

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                button7.Enabled = true;
                
                
            }
            else
            {
                button7.Enabled = false;
                
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {

            

                if (Plate.Check() == true)
                {
                    MessageBox.Show("пряники почти готовы", "Пряник");
                }
                else
                {
                    MessageBox.Show("чего-то не хватает", "Ошибка логики");
                }
                button7.Enabled = false;
                button8.Enabled = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Oven.GetHeat();
            if(Oven.IsReady())
            {
                timer1.Enabled = true;
                button8.Enabled = false;
            }
            

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar2.Increment(+5);
            if(progressBar2.Value == 100)
            {
                timer1.Enabled = false;
                MessageBox.Show("ПРЯНИКИ ГОТОВЫ!", "Пряник", MessageBoxButtons.OK);
                
                    
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
