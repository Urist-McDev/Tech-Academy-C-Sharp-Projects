using System;

namespace C_sharp_challenges
{
    class Program
    {
        static void Main()
        {
            //int num1 = 15;
            //int num2 = 5;

            //Console.WriteLine(num1 + num2);
            //Console.WriteLine(num1 - num2);
            //Console.WriteLine(num1 * num2);
            //Console.WriteLine(num1 / num2);

            //int remainder = 11 % 2;
            //Console.WriteLine(remainder);

            //bool trueOrFalse = 12 < 5;
            //Console.WriteLine(trueOrFalse.ToString());

            //int roomTemp = 70;
            //int currentTemp = 70;
            //bool isWarm = currentTemp >= roomTemp;
            //Console.WriteLine(isWarm);

            string userMulti = Console.ReadLine();
            int multi = Convert.ToInt32(userMulti);
            Console.WriteLine(multi * 50);

            string userAdd = Console.ReadLine();
            int add = Convert.ToInt32(userAdd);
            Console.WriteLine(add + 25);

            string userDevide = Console.ReadLine();
            double devide = Convert.ToDouble(userDevide);
            Console.WriteLine(devide / 12.5);

            string userCompare = Console.ReadLine();
            int compare = Convert.ToInt32(userCompare);
            Console.WriteLine(compare > 50);

            string userRemainder = Console.ReadLine();
            int remainder = Convert.ToInt32(userRemainder);
            Console.WriteLine(remainder % 7);
            Console.ReadLine();
        }
    }
}
