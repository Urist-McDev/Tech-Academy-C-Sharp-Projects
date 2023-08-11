using System;

namespace Loop_assignment
{
    class Program
    {
        static void Main()
        {
            bool isDoWhile = false;
            bool isWhile = true;

            do
            {
                Console.WriteLine("This is a do while loop.");
            }
            while (isDoWhile == true);

            while (isWhile == true)
            {
                Console.WriteLine("This is a while loop.");
            }
        }
    }
}
