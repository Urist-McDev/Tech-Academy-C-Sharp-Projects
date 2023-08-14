using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        try
        {
            List<int> nums = new List<int>() { 14, 78, 45, 12, 67, 784 };
            Console.WriteLine("Please provide a non 0 number");
            int userNum = Convert.ToInt32(Console.ReadLine());
            foreach (int num in nums)
            {
                Console.WriteLine(num / userNum);
            }
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Input must be a number.");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Input can not be 0.");
        }
        finally
        {
            Console.WriteLine("Program finished");
        }
        Console.ReadLine();
    }
}

