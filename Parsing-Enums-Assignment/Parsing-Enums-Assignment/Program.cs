using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parsing_Enums_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a day of the week.");
            string input = Console.ReadLine();
            Enum.TryParse(input, out DaysOfTheWeek userInput);
            Console.WriteLine(userInput);
            Console.ReadLine();
        }
    }
    public enum DaysOfTheWeek
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
}
