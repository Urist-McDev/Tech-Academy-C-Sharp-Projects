using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optional_Arguments_Assignment
{
    class MathMethod
    {
        public int Math(int num1, int num2 = 1)
        {
            return num1 + num2;
        }
    }
}
