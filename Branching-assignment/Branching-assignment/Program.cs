using System;

namespace Branching_assignment
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            Console.WriteLine("Package weight in pounds?");
            int weight = Convert.ToInt32(Console.ReadLine());

            if (weight > 50)
            {
                Console.WriteLine("This package is too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
            }

            Console.WriteLine("Package width in inches.");
            int width = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Package height in inches.");
            int height = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Package length in inches.");
            int length = Convert.ToInt32(Console.ReadLine());

            if (width + height + length > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                Console.ReadLine();
            }
            else
            {
                decimal quote = (height * width * length) * weight / 100;
                Console.WriteLine("Your quote for total shipping cost is: $" + quote);
            }
            Console.ReadLine();
        }
    }
}
