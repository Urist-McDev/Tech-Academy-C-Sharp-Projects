using System;

namespace Branching
{
    class Program
    {
        static void Main()
        {
            int roomTemp = 70;

            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            Console.WriteLine("Hi, " + name + ", what is the temp where you are?");
            int currentTemp = Convert.ToInt32(Console.ReadLine());

            if (currentTemp == roomTemp)
            {
                Console.WriteLine("It is exactly room temp.");
            }
            else if (currentTemp > roomTemp)
            {
                Console.WriteLine("It is warmer than room temp");
            }
            else if (roomTemp > currentTemp)
            {
                Console.WriteLine("It is colder than room temp");
            }
            else
            {
                Console.WriteLine("Something went wrong.");
            }

            Console.ReadLine();

            //int currentTemp = 80;
            //int roomTemp = 70;

            //string comparisonResult = currentTemp == roomTemp ? "It is room temp." : "It is not room temp.";

            //Console.WriteLine(comparisonResult);

            ////if (currentTemp == roomTemp)
            ////{
            ////    Console.WriteLine("It is room temp right now.");
            ////}
            ////else if (currentTemp > roomTemp)
            ////{
            ////    Console.WriteLine("It is warmer than room temp.");
            ////}
            ////else if (currentTemp < roomTemp)
            ////{
            ////    Console.WriteLine("Room temp is warmer than current temp.");
            ////}
            ////else
            ////{
            ////    Console.WriteLine("It is not room temp right now.");
            ////}
            //Console.ReadLine();
        }
    }
}
