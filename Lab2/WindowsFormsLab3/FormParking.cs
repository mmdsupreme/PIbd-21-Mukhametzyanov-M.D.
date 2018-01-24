using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsLab2;

namespace WindowsFormsLab3
{
    public partial class FormParking : Form
    {
        Parking parking;

        public FormParking()
        {
            InitializeComponent();
            parking = new Parking();
            Draw();
        }

        /// <summary>
        /// Метод для отрисовки парковки
        /// </summary>
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxParking.Width, pictureBoxParking.Height);
            Graphics gr = Graphics.FromImage(bmp);
            parking.Draw(gr, pictureBoxParking.Width, pictureBoxParking.Height);
            pictureBoxParking.Image = bmp;
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void buttonSetCar_Click(object sender, EventArgs e)
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

        private void buttonSetSportCar_Click(object sender, EventArgs e)
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

        private void buttonTakeCar_Click(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text != "")
            {
                var car = parking.GetCarInParking(Convert.ToInt32(maskedTextBox1.Text));

                if (car != null)
                {
                    Bitmap bmp = new Bitmap(pictureBoxTakeCar.Width, pictureBoxTakeCar.Height);
                    Graphics gr = Graphics.FromImage(bmp);
                    car.setPosition(5, 5);
                    car.drawCar(gr);
                    pictureBoxTakeCar.Image = bmp;
                    Draw();
                }
            }
        }

    }
}

