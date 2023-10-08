using System.ComponentModel.DataAnnotations;
using System.IO.Enumeration;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

class Journal {
    //Attributes
    public string _entriesFileType = "entries.txt";

    //Constructor
    public Journal() {
        
    }
    public void DisplayAllEntries() {
        string[] entries = System.IO.File.ReadAllLines(_entriesFileType);
        foreach (string entry in entries) {
            Console.WriteLine(entry);
        }
    }
    public void SaveJournalToAFile() {
        //Save the journal to a file - Prompt the user for a filename and then save the current journal (the complete list of entries) to that file location.
        Console.WriteLine("What is the name of the file you would like to save your journal to? ");
        string input = Console.ReadLine();
        using (StreamWriter sw = new StreamWriter(input))
        {
            string[] lines = System.IO.File.ReadAllLines("entries.txt");
            foreach (string line in lines) {
                sw.WriteLine(line);
            }
        }
    }
    public void LoadTheJournalFromAFile() {
        Console.WriteLine("What file would you like to load? ");
        string input = Console.ReadLine();
        string[] file = System.IO.File.ReadAllLines(input);
        StreamWriter sw2 = new StreamWriter("entries.txt");
        foreach (string line in file) {
            sw2.WriteLine(line);
        }
    }

    //('exceeding the requirements')
    public void CreateCSV4Excel() {
        //Improve the process of saving and loading to save as a .csv file that could be opened in Excel (make sure to account for quotation marks and commas correctly in your content.
        Console.WriteLine("Would you like to load a file before saving Entries to a new excel file? (y/n)");
        string uI = Console.ReadLine();
        if (uI == "y") {
            LoadTheJournalFromAFile();
        } else {
            Console.WriteLine("What is the name of the Excel file you would like to save your journal to? ");
            string input = Console.ReadLine();
            using (StreamWriter sw2 = new StreamWriter(input))
            {
                sw2.WriteLine("DateTime, Prompt, UserInput");
                string[] lines = System.IO.File.ReadAllLines("entries.txt");
                foreach (string line in lines) {
                    sw2.WriteLine(line);
                }
            }
        }
        
        // StreamWriter sw = new StreamWriter("excelEntries.csv");
        // sw.WriteLine("DateTime, Prompt, Input");
        // string[] stringedFile = new string;
        // foreach (string line in _entriesFileType) {
        //     sw.WriteLine(line);
        // }
        // Console.WriteLine($"The name of the file is {excelFile}");
    }
}