using NLog;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApplicationlaba2
{
    public partial class Form1 : Form
    {
        private Logger log;
        Parking parking;
        Form2 form;
        public Form1()
        {
            InitializeComponent();
            log = LogManager.GetCurrentClassLogger();
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
            log.Info("Добавление паука:" + parking.getCurrentLevel);
            form = new Form2();
            form.AddIAnimal(AddSpider);
            form.Show();
        }
        public void AddSpider(IAnimal ianimal)
        {
            if (ianimal != null)
            {
                try
                {
                    int place = parking.PutTarantulInShowcase(ianimal);
                    Draw();
                    MessageBox.Show("Ваше место:" + place);
                }
                catch (ParkingOverflowException ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка переполнения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (ParkingAlreadyHaveException ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка совпадения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Общая ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void button5_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > -1)
            {
                string level = listBox1.Items[listBox1.SelectedIndex].ToString();

                if (maskedTextBox1.Text != "")
                {
                    try
                    {
                        IAnimal ianimal = parking.GetTarantulInShowcase(Convert.ToInt32(maskedTextBox1.Text));
                        if (ianimal != null)
                        {
                            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                            Graphics gr = Graphics.FromImage(bmp);
                            ianimal.setPosition(5, 5);
                            ianimal.drawSpiderwolf(gr);
                            pictureBox1.Image = bmp;
                            Draw();
                            log.Info("Изъятие паука с места:" + Convert.ToInt32(maskedTextBox1.Text) + "успешно");
                        }
                    }
                    catch (ParkingIndexOutOfRangeException ex)
                    {
                        MessageBox.Show(ex.Message, "Неверный номер", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Общая ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }

            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)

            {

                if (parking.SaveData(saveFileDialog1.FileName))

                {

                    MessageBox.Show("Сохранение прошло успешно", "",

                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

                else

                {

                    MessageBox.Show("Не сохранилось", "",

                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
        }

        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)

            {

                if (parking.LoadData(openFileDialog1.FileName))

                {

                    MessageBox.Show("Загрузили", "",

                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

                else

                {

                    MessageBox.Show("Не загрузили", "",

                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

                Draw();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            parking.LevelUp();
            log.Info("Переход на уровень выше Текущий уровень:" + parking.getCurrentLevel);
            listBox1.SelectedIndex = parking.getCurrentLevel;
            Draw();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            parking.LevelDown();
            log.Info("Переход на уровень ниже Текущий уровень:" + parking.getCurrentLevel);
            listBox1.SelectedIndex = parking.getCurrentLevel;
            Draw();
           
        }

        private void buttonsort_Click(object sender, EventArgs e)
        {
            parking.Sort();
            Draw();
            log.Info("Сортировка уровня " + parking.getCurrentLevel);
        }
    }
}
