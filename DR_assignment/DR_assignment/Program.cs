using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("The Tech Academy");
        Console.WriteLine("Student Daily Report");

        
        Console.WriteLine("What is your name?");
        string name = Console.ReadLine();

        Console.WriteLine("What Course are you on?");
        string course = Console.ReadLine();

        Console.WriteLine("What page number?");
        string pageNumber = Console.ReadLine();
        int pageNum = Convert.ToInt32(pageNumber);

        Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\".");
        string helpNeeded = Console.ReadLine();
        bool help = Convert.ToBoolean(helpNeeded);

        Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
        string positiveFeedback = Console.ReadLine();

        Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
        string anyFeedback = Console.ReadLine();

        Console.WriteLine("How many hours did you study today?");
        string hoursStudyed = Console.ReadLine();
        int hours = Convert.ToInt32(hoursStudyed);

        Console.ReadLine();
    }
}

