using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to your journal! \nPlease pick one of the following: ");
        Console.WriteLine("Write a new entry (press '1')");
        Console.WriteLine("Display the journal (press '2')");
        Console.WriteLine("Save the journal to a file (press '3')");
        Console.WriteLine("Load the journal from a file (press '4') ");
        string userInput = Console.ReadLine();
        if (userInput == "1") {
            Console.WriteLine("Would you like to create a new entry today? (y/n) ");
            string userInput2 = Console.ReadLine();
            if (userInput2 == "y") {
                Console.WriteLine("Your prompt for the day is: ");
                Prompts InstanceOfPromptClass = new Prompts();
                InstanceOfPromptClass.DisplayRandomPrompt();
                string input = Console.ReadLine();
                Entries InstanceOfEntriesClass = new Entries();
                InstanceOfEntriesClass.AddEntryToEntries(input);
                
            }
            else {
                Console.WriteLine("Okay bye!");
            }
        }
        else if (userInput == "2")
        {
            //Journal.DisplayAllEntries();
        }
        else if (userInput == "3")
        {
            //Journal.SaveJournalToAFile();
        }
        else if (userInput == "4")
        {
            //Journal.LoadTheJournalFromAFile();
        }
    }
}