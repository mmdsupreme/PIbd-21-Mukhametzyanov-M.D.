﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class StoreIndexOutOfRangeExeption : Exception
    {
        public StoreIndexOutOfRangeExeption() :
            base("Нет машины с таким номером") { }
    }
}
