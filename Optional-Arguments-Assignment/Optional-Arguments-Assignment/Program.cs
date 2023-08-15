using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optional_Arguments_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number. After, you can enter a second number as well, but it is not needed.");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int? num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The sum is: " + MathMethod.Math(num1, num2));

            Console.ReadLine();
        }
    }
}
