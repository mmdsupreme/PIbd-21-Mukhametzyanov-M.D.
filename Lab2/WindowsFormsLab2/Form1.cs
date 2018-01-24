using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsLab2
{
    public partial class Form1 : Form
    {
        Color color;
        Color dopColor;
        int maxSpeed;
        int maxCountPass;
        int weight;


        private ITransport inter;
        public Form1()
        {
            InitializeComponent();
            color = Color.White;
            dopColor = Color.Black;
            maxSpeed = 150;
            maxCountPass = 4;
            weight = 1500;
            buttonSelectColor.BackColor = color;
            buttonSelectDopColor.BackColor = dopColor;

        }

        private void buttonSelectColor_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                color = cd.Color;
                buttonSelectColor.BackColor = color;
            }
        }

        private void buttonSelectDopColor_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                dopColor = cd.Color;
                buttonSelectDopColor.BackColor = dopColor;
            }

        }

        private bool checkFields()
        {
            if (!int.TryParse(textBoxMaxSpeed.Text, out maxSpeed))
            {
                return false;
            }
            if (!int.TryParse(textBoxMaxCountPassenget.Text, out maxCountPass))
            {
                return false;
            }
            if (!int.TryParse(textBoxWeight.Text, out weight))
            {
                return false;
            }
            return true;
        }

        private void buttonSetAuto_Click(object sender, EventArgs e)
        {
            if (checkFields())
            {
                inter = new Car(maxSpeed, maxCountPass, weight, color);
                Bitmap bmp = new Bitmap(pictureBoxDraw.Width, pictureBoxDraw.Height);
                Graphics gr = Graphics.FromImage(bmp);
                inter.drawCar(gr);
                pictureBoxDraw.Image = bmp;
            }

        }

        private void buttonMove_Click(object sender, EventArgs e)
        {
            if (inter != null)
            {
                Bitmap bmp = new Bitmap(pictureBoxDraw.Width, pictureBoxDraw.Height);
                Graphics gr = Graphics.FromImage(bmp);
                inter.moveCar(gr);
                pictureBoxDraw.Image = bmp;

            }
        }

        private void buttonSetSportCar_Click(object sender, EventArgs e)
        {
            if (checkFields())
            {
                inter = new Jeep(maxSpeed, maxCountPass, weight, color, checkBoxFrontSpoiler.Checked, checkBoxBackSpoiler.Checked, checkBoxSideSpoiler.Checked, dopColor);
                Bitmap bmp = new Bitmap(pictureBoxDraw.Width, pictureBoxDraw.Height);
                Graphics gr = Graphics.FromImage(bmp);
                inter.drawCar(gr);
                pictureBoxDraw.Image = bmp;
            }

        }
    }
}
