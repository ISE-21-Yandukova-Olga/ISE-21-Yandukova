using System;
using NLog;

using System.Drawing;

using System.Windows.Forms;

namespace WindowsFormsApplicationlaba2
{
    public partial class Form2 : Form
    {
        private Logger log;
        IAnimal ianimal = null;
        public IAnimal getIAnimal { get { return ianimal; } }

        private void Draw()
        {
            if (ianimal != null)
            {
                Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                Graphics gr = Graphics.FromImage(bmp);
                ianimal.setPosition(10, 30);
                ianimal.drawSpiderwolf(gr);
                pictureBox1.Image = bmp;
            }
        }


        public Form2()
        {
            log = LogManager.GetCurrentClassLogger();
            InitializeComponent();
            panelColorBlack.MouseDown += panelColor_MouseDown;
            panelColorYellow.MouseDown += panelColor_MouseDown;
            panelColorWhite.MouseDown += panelColor_MouseDown;
            panelColorRed.MouseDown += panelColor_MouseDown;
            panelColorGrey.MouseDown += panelColor_MouseDown;
            panelColorBlue.MouseDown += panelColor_MouseDown;

            buttonAnnulment.Click += (object sender, EventArgs e) => { Close(); };

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBoxStone_Enter(object sender, EventArgs e)
        {

        }

        private void buttonBaseColor_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }



        private void labelBaseColor_DragDrop(object sender, DragEventArgs e)
        {

            if (ianimal != null)
            {
                ianimal.setMainColor((Color)e.Data.GetData(typeof(Color)));
                Draw();


            }
        }

        private void labelBaseColor_DragEnter(object sender, DragEventArgs e)
        {
            log.Info("Выбор цвета:" + (Color)e.Data.GetData(typeof(Color)));
            if (e.Data.GetDataPresent(typeof(Color)))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void labelDopColor_DragDrop(object sender, DragEventArgs e)
        {
            log.Info("Выбор доп.цвета:" + (Color)e.Data.GetData(typeof(Color)));
            if (ianimal != null)
            {
                if (ianimal is Tarantul)
                {
                    (ianimal as Tarantul).setDopColor((Color)e.Data.GetData(typeof(Color)));
                    Draw();
                }
            }
        }

        private void panelColor_MouseDown(object sender, MouseEventArgs e)
        {
            (sender as Control).DoDragDrop((sender as Control).BackColor, DragDropEffects.Move | DragDropEffects.Copy);
        }


        private event myDel eventAddIAnimal;

        public void AddIAnimal(myDel ev)
        {
            if (eventAddIAnimal == null)
            {
                eventAddIAnimal = new myDel(ev);
            }
            else eventAddIAnimal += ev;
        }










        private void panel1_DragDrop(object sender, DragEventArgs e)
        {
            switch (e.Data.GetData(DataFormats.Text).ToString())
            {
                case "Spiderswolf":
                    ianimal = new Spiderswolf(30, 4, Color.Black);
                    break;
                case "Tarantul":
                    ianimal = new Tarantul(30, 4, Color.Black, true, Color.Black);
                    break;
            }
            Draw();
        }

        private void panel1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void buttonBaseColor_Click_1(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (eventAddIAnimal != null)
            {
                eventAddIAnimal(ianimal);
            }
            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void labelSpiderswolf_MouseDown(object sender, MouseEventArgs e)
        {
            log.Info("Перемещение паука");
            buttonSpiderswolf.DoDragDrop(buttonSpiderswolf.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void labelTarantul_MouseDown(object sender, MouseEventArgs e)
        {
            log.Info("Перемещение тарантула");
            buttonTarantul.DoDragDrop(buttonTarantul.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }
    }
}

