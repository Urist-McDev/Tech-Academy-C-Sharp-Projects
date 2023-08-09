using System;

namespace Boolean_logic_assignment
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("What is your age?");
            string ageInYears = Console.ReadLine();
            int age = Convert.ToInt32(ageInYears);

            Console.WriteLine("Have you sever had a DUI?");
            string everHadDUI = Console.ReadLine();
            bool DUI = Convert.ToBoolean(everHadDUI);

            Console.WriteLine("How many speeding tickets do you have?");
            string numOfSpeedingTickets = Console.ReadLine();
            int numTickets = Convert.ToInt32(numOfSpeedingTickets);

            Console.WriteLine("Qualified for car insurence?");
            bool qualified = age > 15 && DUI == false && numTickets < 3;
            Console.WriteLine(qualified);

            Console.ReadLine();
        }
    }
}
