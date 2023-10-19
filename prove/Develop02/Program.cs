using System;
using System.Reflection.Metadata;

class Program {
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        Prompts prompt = new Prompts();
        Entries InstanceOfEntriesClass = new Entries();

        string userInput = "10";
        Console.WriteLine("Welcome to your journal! ");
        while (userInput != "0") {
            string randomGeneratedPrompt = prompt.GetRandomPrompt();
            Console.WriteLine("Please pick one of the following: ");
            Console.WriteLine("Write a new entry (press '1')");
            Console.WriteLine("Display the journal (press '2')");
            Console.WriteLine("Save the journal to a file (press '3')");
            Console.WriteLine("Load the journal from a file (press '4') ");
            Console.WriteLine("Get excel formated CSV (press '5') ");
            Console.WriteLine("Exit (press '0') ");

            userInput = Console.ReadLine();
            if (userInput == "1") { //Write a new entry - Show the user a random prompt (from a list that you create), and save their response, the prompt, and the date as an Entry.
                    Console.WriteLine("Your prompt for the day is: ");
                    Console.WriteLine(randomGeneratedPrompt);
                    string input = Console.ReadLine();
                    string datime = InstanceOfEntriesClass.GetCurrentDateTimeStamp();
                    InstanceOfEntriesClass.AddEntryToEntries(datime, randomGeneratedPrompt, input);
            }
            else if (userInput == "2")
            {
                journal.DisplayAllEntries(); //Display the journal - Iterate through all entries in the journal and display them to the screen.
            }
            else if (userInput == "3")
            {
                journal.SaveJournalToAFile(); //Save the journal to a file - Prompt the user for a filename and then save the current journal (the complete list of entries) to that file location.
            }
            else if (userInput == "4")
            {
                journal.LoadTheJournalFromAFile(); //Load the journal from a file - Prompt the user for a filename and then load the journal (a complete list of entries) from that file. This should replace any entries currently stored the journal.
            }
            // else if (userInput == "5")
            // {
            //     journal.CreateCSV4Excel();
            // }
        }
    }
}