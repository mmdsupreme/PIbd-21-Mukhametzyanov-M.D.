using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Jeep : Car
    {
        private bool suspension;
        private bool reserve;
        private bool exhaustPipe;
        private Color dopColor;

        public Jeep(int maxSpeed, int maxCountPassengers, double weight, Color color, bool suspension, bool reserve, bool exhaustPipe, Color dopColor) : base(maxSpeed, maxCountPassengers, weight, color)
        {
            this.suspension = suspension;
            this.reserve = reserve;
            this.exhaustPipe = exhaustPipe;
            this.dopColor = dopColor;
        }

        protected override void drawBaseCar(Graphics g)
        {
            if (suspension)
            {
                Pen pen = new Pen(Color.Black);
                g.DrawEllipse(pen, startPosX + 60, startPosY - 6, 20, 20);
                g.DrawEllipse(pen, startPosX + 60, startPosY + 35, 20, 20);
                g.DrawEllipse(pen, startPosX + 8, startPosY - 6, 20, 20);
                g.DrawEllipse(pen, startPosX + 8, startPosY + 35, 20, 20);
                g.DrawRectangle(pen, startPosX + 80, startPosY + 10, 15, 20);
                g.DrawRectangle(pen, startPosX + 80, startPosY + 27, 15, 20);
                g.DrawRectangle(pen, startPosX, startPosY - 6, 14, 15);
                g.DrawRectangle(pen, startPosX, startPosY + 40, 14, 15);

                Brush suspension = new SolidBrush(dopColor);


                g.FillRectangle(suspension, startPosX, startPosY - 5, 15, 15);
                g.FillRectangle(suspension, startPosX, startPosY + 40, 15, 15);
            }



            if (reserve)
            {
                Brush spoiler = new SolidBrush(dopColor);
                g.FillRectangle(spoiler, startPosX - 10, startPosY, 10, 30);
                Pen pen = new Pen(Color.Black);
                g.DrawRectangle(pen, startPosX - 5, startPosY, 10, 50);

            }
            if (exhaustPipe)
            {
                Pen pen = new Pen(Color.Black);

                g.DrawRectangle(pen, startPosX + 25, startPosY + 50, 10, 10);

                Brush pipe = new SolidBrush(dopColor);

                g.FillRectangle(pipe, startPosX + 25, startPosY + 45, 10, 15);

            }
            base.drawBaseCar(g);
            Brush br = new SolidBrush(dopColor);



            g.FillRectangle(br, startPosX + 15, startPosY + 15, 35, 5);
            g.FillRectangle(br, startPosX + 15, startPosY + 30, 35, 5);

        }

        public void setDopColor(Color color)
        {
            dopColor = color;
        }


    }
}
