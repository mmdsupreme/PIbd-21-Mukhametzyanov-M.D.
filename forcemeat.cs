using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class forcemeat
    {
        private int temperature = 0;

        public double Count
        {
            set;
            get;
        }

        public int Temperature
        {
            get
            {
                return temperature;
            }
        }

        public void GetHeat()
        {
            if (temperature < 100)
            {
                temperature++;
            }
        }

        public bool State
        {
            set;
            get;
        }

        public forcemeat GetOil()
        {
            if (State)
            {
                return new forcemeat();
            }
            else
            {
                return null;
            }
        }
    }
}
