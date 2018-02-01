using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class knife
    {
        public void Break(potato potato)
        {
            if (potato.Have_shell)
            {
                potato.Have_shell = false;
            }
        }
    }
}
