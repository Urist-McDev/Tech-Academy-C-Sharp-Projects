using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datetime_assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine("Please enter a number.");
            int userNum = Convert.ToInt32(Console.ReadLine());
            TimeSpan time = new TimeSpan(userNum, 0, 0);

            Console.WriteLine(DateTime.Now + time);

            Console.ReadLine();
        }
    }
}
