using System;

namespace strings
{
    class Program
    {
        static void Main()
        {
            string part1 = "This ";
            string part2 = "is built ";
            string part3 = "from three parts.";

            string upperCase = "this string will be in uppercase.";

            Console.WriteLine(part1 + part2 + part3);
            Console.WriteLine(upperCase.ToUpper());

            Console.ReadLine();
        }
    }
}
