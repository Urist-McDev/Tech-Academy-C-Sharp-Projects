using System;

namespace Math_and_Comparison_assignment
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1");

            Console.WriteLine("Hourly rate?");
            string person1HourlyRate = Console.ReadLine();
            int person1Rate = Convert.ToInt32(person1HourlyRate);
            Console.WriteLine("Hours worked per week?");
            string person1HoursWorked = Console.ReadLine();
            int person1Hours = Convert.ToInt32(person1HoursWorked);

            Console.WriteLine("Person 2");

            Console.WriteLine("Hourly rate?");
            string person2HourlyRate = Console.ReadLine();
            int person2Rate = Convert.ToInt32(person2HourlyRate);
            Console.WriteLine("Hours worked per week?");
            string person2HoursWorked = Console.ReadLine();
            int person2Hours = Convert.ToInt32(person2HoursWorked);

            Console.WriteLine("Annual salary of Person 1:");
            int person1TotalHours = person1Hours * 52;
            int person1AnnualSalary = person1TotalHours * person1Rate;
            Console.WriteLine(person1AnnualSalary);

            Console.WriteLine("Annual salary of Person 2:");
            int person2TotalHours = person2Hours * 52;
            int person2AnnualSalary = person2TotalHours * person2Rate;
            Console.WriteLine(person2AnnualSalary);

            Console.WriteLine("Does Person 1 make more money than Person 2?");
            bool moneyCompare = person1AnnualSalary > person2AnnualSalary;
            Console.WriteLine(moneyCompare);
            Console.ReadLine();
        }
    }
}
