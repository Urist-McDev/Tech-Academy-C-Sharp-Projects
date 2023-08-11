using System;
using System.Collections.Generic;

namespace Arrays_assignment
{
    class Program
    {
        static void Main()
        {
            string[] cakes = { "Vanilla", "Chocolate", "Marbled", "Red Velvet" };
            int[] intArray = { 4, 6, 9, 541, 67842 };

            Console.WriteLine("For a string, pick a number between 0 and 3");
            int stringChoice = Convert.ToInt32(Console.ReadLine());
            if (stringChoice >= cakes.Length)
            {
                Console.WriteLine("Your choice must be bewteen 0 and 3.");
            }
            else
            {
                Console.WriteLine(cakes[stringChoice]);
            }

            Console.WriteLine("For a interger, pick a number between 0 and 4");
            int intChoice = Convert.ToInt32(Console.ReadLine());
            if (intChoice >= intArray.Length)
            {
                Console.WriteLine("Your choice must be bewteen 0 and 4.");
            }
            else
            {
                Console.WriteLine(intArray[intChoice]);
            }

            List<string> weapons = new List<string>();
            weapons.Add("Axe");
            weapons.Add("Sword");
            weapons.Add("Bow");
            weapons.Add("Spear");

            Console.WriteLine("For a weapon, pick a number between 0 and 3");
            int weaponChoice = Convert.ToInt32(Console.ReadLine());
            if (weaponChoice >= weapons.Count)
            {
                Console.WriteLine("Your choice must be bewteen 0 and 3");
            }
            else
            {
                Console.WriteLine(weapons[weaponChoice]);
            }

            Console.ReadLine();
        }
    }
}
