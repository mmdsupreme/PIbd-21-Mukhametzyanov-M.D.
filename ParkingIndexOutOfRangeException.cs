using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class ParkingIndexOutOfRangeException : Exception
    {
        public ParkingIndexOutOfRangeException() :
            base("На парковке объекта под таким номером нет")
        { }
    }
}
