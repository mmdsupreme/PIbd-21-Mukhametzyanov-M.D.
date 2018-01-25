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
            {
                if (listBoxLevels.SelectedIndex > -1)
                {
                    string level = listBoxLevels.Items[listBoxLevels.SelectedIndex].ToString();
                    if (maskedTextBox1.Text != "")
                    {
                        var car = parking.GetCarInParking(Convert.ToInt32(maskedTextBox1.Text));

                        Bitmap bmp = new Bitmap(pictureBoxTakeCar.Width, pictureBoxTakeCar.Height);
                        Graphics gr = Graphics.FromImage(bmp);
                        car.setPosition(20, 50);
                        car.drawCar(gr);
                        pictureBoxTakeCar.Image = bmp;
                        Draw();
                    }
                    else
                    {
                        MessageBox.Show("Извинте, на этом месте нет машины");
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
            Draw();

        }

        private void buttonUp_Click(object sender, EventArgs e)
        {
            parking.LevelUp();
            listBoxLevels.SelectedIndex = parking.getCurrentLevel;
            Draw();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            form = new Form1();
            form.AddEvent(AddLoco);
            form.Show();

        }

        private void AddLoco(ITransport car)
        {
            if (car != null)
            {
                int place = parking.PutCarInParking(car);
                if (place > -1)
                {
                    Draw();
                    MessageBox.Show("Ваше место: " + place);
                }
                else
                {
                    MessageBox.Show("Машину не удалось поставить");
                }
            }
        }

    }
}

