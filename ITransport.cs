using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public interface ITransport
    {
        void moveCar(Graphics g);

        void drawCar(Graphics g);

        void setPosition(int x , int y);

        void loadPassengers(int count);   

        int getPassenger();

        void setMainColor(Color color);

        string getInfo();
    }
}
