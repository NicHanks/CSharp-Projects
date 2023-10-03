using System.IO;

class Entries {
    //Attributes
    private string _fileOfEntries = "entries.txt";
    private string _prompt;
    private string _entry;
    private string _dateTime;

    //Constructor
    public Entries() {

    }

    //Methods
    public void AddEntryToEntries(string input) {
        using (StreamWriter outputFile = new StreamWriter(_fileOfEntries))
        {
            // You can add text to the file with the WriteLine method
            outputFile.WriteLine("This will be the first line in the file.");
            string dateTime = GetCurrentDateTimeStamp();
            outputFile.WriteLine($"{dateTime} -- {input}");
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