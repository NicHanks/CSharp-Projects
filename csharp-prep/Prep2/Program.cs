using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the percentage? ");
        string percentageString = Console.ReadLine();
        int percentageInt = int.Parse(percentageString);


        if (percentageInt >= 90)
        {
            Console.WriteLine("Congrates! You got an A!");
        }
        else if (percentageInt >= 80)
        {
            Console.WriteLine("Congrates! You got an B!");

        }
        else if (percentageInt >= 70)
        {
            Console.WriteLine("Congrates! You got an C!");

        }
        else if (percentageInt >= 60)
        {
            Console.WriteLine("Congrates! You got an D!");

        }
        else if (percentageInt < 60)
        {
            Console.WriteLine("Congrates! You got an E!");

        }
    }
}
