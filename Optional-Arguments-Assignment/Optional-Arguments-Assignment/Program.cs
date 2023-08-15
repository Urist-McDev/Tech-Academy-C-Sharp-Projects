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
            MathMethod mathMethod = new MathMethod();

            Console.WriteLine("Enter first number.");
            int num1 = Convert.ToInt32(Console.ReadLine());
            
            try
            {
                Console.WriteLine("Enter a second number. This is optional.");
                int num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(mathMethod.Math(num1, num2));
            }
            catch
            {
                Console.WriteLine(mathMethod.Math(num1));
            }

            Console.ReadLine();
        }
    }
}
