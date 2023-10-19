using System.IO;

class Entries {
    //Attributes
    private string _fileOfEntries = "entries.txt";
    //private string _prompt;
    //private string _entry;
    //private string _dateTime;

    //Constructor
    public Entries() {

    }

    //Methods
    public void AddEntryToEntries(string datime, string randomGeneratedPrompt, string input) {
        using (StreamWriter outputFile = new StreamWriter(_fileOfEntries))
        {
            // You can add text to the file with the WriteLine method
            string dateTime = GetCurrentDateTimeStamp();
            outputFile.WriteLine($"{datime} -- {randomGeneratedPrompt} -- {input}");
        }
    }

    public void DisplayRandomPrompt() {

    }

    public void GetUserInput() {

    } 
    public string GetCurrentDateTimeStamp() {
        DateTime currentDateTime = DateTime.Now;
        string dateTime = currentDateTime.ToString();
        return dateTime;
    }
}