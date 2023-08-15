using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            voidStuff voidStuff = new voidStuff();

            int userNum = Convert.ToInt32(Console.ReadLine());
            voidStuff.Math(userNum);

            Console.WriteLine("Enter name.");
            string name = Console.ReadLine();
            Console.WriteLine(staticClass.Greeting(name));

            Console.ReadLine();
        }
    }
}
