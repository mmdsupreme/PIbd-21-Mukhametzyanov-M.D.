
using NLog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class FormParkingcs : Form
    {
        Parking parking;
        Form1 form;
        private Logger log = LogManager.GetCurrentClassLogger();
        public FormParkingcs()
        {
            InitializeComponent();           
            parking = new Parking(5);
            for (int i = 1; i < 6; i++)
            {
                listBoxLevels.Items.Add("Уровень " + i);
            }
            listBoxLevels.SelectedIndex = parking.getCurrentLevel;
   
            Draw();
        }

        private void Draw()
        {
            if (listBoxLevels.SelectedIndex > -1)
            {
                Bitmap bmp = new Bitmap(pictureBoxParking.Width, pictureBoxParking.Height);
                Graphics gr = Graphics.FromImage(bmp);
                parking.Draw(gr, pictureBoxParking.Width, pictureBoxParking.Height);
                pictureBoxParking.Image = bmp;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                var car = new Car(100, 4, 1000, dialog.Color);
                int place = parking.PutCarInParking(car);
                Draw();
                MessageBox.Show("Ваше место: " + place);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                ColorDialog dialog = new ColorDialog();
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    ColorDialog dialogDop = new ColorDialog();
                    if (dialogDop.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        var car = new Jeep(100, 4, 1000, dialog.Color, true, true, true, dialogDop.Color);
                        int place = parking.PutCarInParking(car);
                        Draw();
                        MessageBox.Show("Ваше место: " + place);
                    }
                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBoxLevels.SelectedIndex > -1)
                {//Прежде чем забрать машину, надо выбрать с какого уровня будем забирать
                    string level = listBoxLevels.Items[listBoxLevels.SelectedIndex].ToString();
                    if (maskedTextBox1.Text != "")
                    {
                        try
                        {
                            ITransport car = parking.GetCarInParking(Convert.ToInt32(maskedTextBox1.Text));

                            Bitmap bmp = new Bitmap(pictureBoxTakeCar.Width, pictureBoxTakeCar.Height);
                            Graphics gr = Graphics.FromImage(bmp);
                            car.setPosition(20, 50);
                            car.drawCar(gr);
                            pictureBoxTakeCar.Image = bmp;
                            Draw();
                        }
                        catch (ParkingIndexOutOfRangeException ex)
                        {
                            MessageBox.Show(ex.Message, "Неверный номер",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Общая ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
            }            
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonDown_Click(object sender, EventArgs e)
        {

            parking.LevelDown();
            listBoxLevels.SelectedIndex = parking.getCurrentLevel;
            log.Info("Переход на уровень ниже Текущий уровень: " + parking.getCurrentLevel);
            Draw();

        }

        private void buttonUp_Click(object sender, EventArgs e)
        {

            parking.LevelUp();
            listBoxLevels.SelectedIndex = parking.getCurrentLevel;
            log.Info("Переход на уровень выше Текущий уровень: " + parking.getCurrentLevel);
            Draw();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            log.Info("Вызов  ");
            form = new Form1();
            form.AddEvent(AddLoco);
            log.Info("Вызов car ");
            form.Show();

        }

        private void AddLoco(ITransport car)
        {
            if (car != null)
            {
                try
                {
                    int place = parking.PutCarInParking(car);
                    Draw();
                    MessageBox.Show("Ваше место: " + place);
                }
                catch (ParkingOverflowException ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка переполнения",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)                                                                                                                 //обработка искл
                {                
                    MessageBox.Show(ex.Message, "Общая ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
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

        private void button2_Click_1(object sender, EventArgs e)
        {
            parking.Sort();
        }
    }
}

