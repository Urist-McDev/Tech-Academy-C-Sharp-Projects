using System;

using System.Collections.Generic;

class Program
{
    static void Main()
    {
        //string[] textArray = { "The First: ", "The Second: ", "The Third: ", "The Fourth: " };

        //Console.WriteLine("Please input some text.");
        //string userInput = Console.ReadLine();

        //for (int i = 0; i < textArray.Length; i++)
        //{
        //    textArray[i] = textArray[i] + userInput;
        //}

        //foreach (string text in textArray)
        //{
        //    Console.WriteLine(text);
        //}

        //int counter = 0;
        //while (counter < 11)
        //{
        //    Console.WriteLine(counter);
        //    counter++;
        //}

        //int counter2 = 0;
        //while (counter2 <= 15)
        //{
        //    Console.WriteLine(counter2);
        //    counter2++;
        //}

        //List<string> cakes = new List<string>() { "Vanilla", "Chocolate", "Marbled", "Red Velvet" };
        //Console.WriteLine("Please enter a cake flavor");
        //string userCake = Console.ReadLine();

        //if (cakes.Contains(userCake))
        //{
        //    for (int i = 0; i < cakes.Count; i++)
        //    {
        //        if (userCake == cakes[i])
        //        {
        //            Console.WriteLine("We have that flavor!");
        //            break;
        //        }
        //    }
        //}
        //else
        //{
        //    Console.WriteLine("We don't have that flavor.");
        //}

        //Console.ReadLine();

        //List<string> cakes = new List<string>() { "Vanilla", "Chocolate", "Marbled", "Red Velvet", "Vanilla", "Marbled" };
        //Console.WriteLine("Please enter a cake flavor");
        //string userCake = Console.ReadLine();

        //if (cakes.Contains(userCake))
        //{
        //    for (int i = 0; i < cakes.Count; i++)
        //    {
        //        if (userCake == cakes[i])
        //        {
        //            Console.WriteLine(cakes[i]);
        //        }
        //    }
        //}
        //else
        //{
        //    Console.WriteLine("We don't have that flavor.");
        //}

        //Console.ReadLine();

        List<string> cakes = new List<string>() { "Vanilla", "Chocolate", "Marbled", "Red Velvet", "Vanilla", "Marbled" };

        foreach (string cake in cakes)
        {
            Console.WriteLine(cake);
        }
        Console.ReadLine();
    }
}

