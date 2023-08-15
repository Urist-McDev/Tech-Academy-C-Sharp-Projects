using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace void_method_assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            voidMath voidMath = new voidMath();

            voidMath.Add(7, 8);
            voidMath.Add(num1: 4, num2: 9);

            Console.ReadLine();
        }
    }
}
