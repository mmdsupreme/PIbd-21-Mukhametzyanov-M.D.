using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class WaterTap
    {
        public bool State
        {
            set;
            get;
        }

        public void Wash(potato potato)
        {
            if (State)
            {
                potato.Dirty = 0;
            }
        }
    }
}
