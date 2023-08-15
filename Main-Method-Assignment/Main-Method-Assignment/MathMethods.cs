using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Method_Assignment
{
    class MathMethods
    {
        public int Add(int num)
        {
            return num + 5;
        }

        public int Add(decimal num)
        {
            decimal sum = num + 4;
            return Convert.ToInt32(sum);
        }

        public int Add(string num)
        {
            int sum = Convert.ToInt32(num) + 7;
            return sum;
        }
    }
}
