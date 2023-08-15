using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Assignment
{
    class voidStuff
    {
        public void Math(int num)
        {
            Console.WriteLine(num / 2);
        }

        public void Math(int num, out int numUsed)
        {
            Console.WriteLine(num / 2);

            numUsed = num;
        }
    }
}
