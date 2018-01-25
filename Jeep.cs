using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Jeep : Car, IComparable<Jeep>, IEquatable<Jeep>
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


        public Jeep(string info) : base(info)
        {
            string[] strs = info.Split(';');
            if (strs.Length == 8) {
                MaxSpeed = Convert.ToInt32(strs[0]);
                MaxCountPassengers = Convert.ToInt32(strs[1]);
                Weight = Convert.ToInt32(strs[2]);
                ColorBody = Color.FromName(strs[3]);
                suspension = Convert.ToBoolean(strs[4]);
                reserve = Convert.ToBoolean(strs[5]);
                exhaustPipe = Convert.ToBoolean(strs[6]);
                dopColor = Color.FromName(strs[7]);
            }
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

                Brush suspen = new SolidBrush(dopColor);


                g.FillRectangle(suspen, startPosX, startPosY - 5, 15, 15);
                g.FillRectangle(suspen, startPosX, startPosY + 40, 15, 15);
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

        public override string getInfo()
        {
            return MaxSpeed + ";" + MaxCountPassengers + ";" + Weight + ";" + ColorBody.Name + ";" + suspension + ";" + reserve + ";" + exhaustPipe + ";" + dopColor.Name;
        }

        public int CompareTo(Jeep other)                                                                                                             
        {
            var res = (this is Vehicle).CompareTo(other is Vehicle);
            if (res != 0)
            {
                return res;
            }
            if (suspension != other.suspension)
            {
                return suspension.CompareTo(other.suspension);
            }
            if (exhaustPipe != other.exhaustPipe)
            {
                return exhaustPipe.CompareTo(other.exhaustPipe);
            }
            if (reserve != other.reserve)
            {
                return reserve.CompareTo(other.reserve);
            }
            if (dopColor != other.dopColor)
            {
                return dopColor.Name.CompareTo(other.dopColor);
            }
            return 0;
        }
        public bool Equals(Jeep other)
        {
            var res = (this is Vehicle).Equals(other is Vehicle);
            if (!res)
            {
                return res;
            }
            if (suspension != other.suspension)
            {
                return false;
            }
            if (exhaustPipe != other.exhaustPipe)
            {
                return false;
            }
            if (reserve != other.reserve)
            {
                return false;
            }
            if (dopColor != other.dopColor)
            {
                return false;
            }

            return true;
        }
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            Jeep carObj = obj as Jeep;
            if (carObj == null)
            {
                return false;
            }
            else
            {
                return Equals(carObj);
            }
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
