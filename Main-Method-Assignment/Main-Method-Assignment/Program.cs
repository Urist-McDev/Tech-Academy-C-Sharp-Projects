using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Method_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 5;
            decimal num2 = 2.7m;
            string num3 = "8";

            MathMethods mathMethods = new MathMethods();

            Console.WriteLine(mathMethods.Add(num));
            Console.WriteLine(mathMethods.Add(num2));
            Console.WriteLine(mathMethods.Add(num3));

            Console.ReadLine();
        }
    }
}
