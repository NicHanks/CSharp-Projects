using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        Scripture script = new Scripture("Moroni 10:12 ", "For he grew in strength and Wisdom. ");
        Console.Clear();
        Console.WriteLine("Here's a scripture game!");
        script.DisplayVerse();
        Console.WriteLine("Do you want to continue? [y/n]");
        string userInput = Console.ReadLine();
        while (userInput == "y") {
            Console.Clear();
            script.HideWords();
            script.DisplayModifiedVerse();
            Console.WriteLine("Do you want to continue? [y/n]");
            userInput = Console.ReadLine();
        } 
        if (userInput == "n") {
            Console.WriteLine("Would you like a different scripture? [y/n]");
            string uI = Console.ReadLine();
            if (uI == "y") {
                Console.WriteLine("Ok, here's your new scripture. :)");
                Scripture script2 = new Scripture("Alma 31:7 ", "Have ye faith, and be likened unto a child. ");
                script2.DisplayVerse();
                Console.WriteLine("Do you want to continue? [y/n]");
                userInput = Console.ReadLine();
                while (userInput == "y") {
                    Console.Clear();
                    script2.HideWords();
                    script2.DisplayModifiedVerse();
                    Console.WriteLine("Do you want to continue? [y/n]");
                    userInput = Console.ReadLine();
                }
            }
        } else 
        {
            Console.WriteLine("Thanks for playing! \nHate to see you go! ");
        }
    }
}