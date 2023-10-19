using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Here is a scripture!");
        Scripture script = new Scripture("Moroni 10:12", "yo muma! ");
        Console.WriteLine(script.DisplayVerse());
        Console.WriteLine("If you want to continue type [C]/n If you want to quite hit [Q] ");
        string userInput = Console.ReadLine();
        if (userInput = "C") {
            script.HideWords();
        }

    }
}