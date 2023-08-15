using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calling_Methods_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pick a number to do math on.");
            int userNum = Convert.ToInt32(Console.ReadLine());
            int userAdded = Math.Add(userNum);
            int userSub = Math.Subtract(userNum);
            int userMulti = Math.Multiply(userNum);

            Console.WriteLine(userNum + " + 5 is " + userAdded);
            Console.WriteLine(userNum + " - 5 is " + userSub);
            Console.WriteLine(userNum + " * 5 is " + userMulti);

            Console.ReadLine();
        }
    }
}
