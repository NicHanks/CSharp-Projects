using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

class Journal {
    //Attributes
    public string _name;
    public List<Entries> _Entries;
    public DateTime _dateTime;

    //Constructor
    public Journal() {
        
    }
    public void DisplayAllEntries() {

    }
    public void SaveJournalToAFile() {

    }
    public void LoadTheJournalFromAFile() {

    }



    //extras (do these for 'exceeding the requirements')
    public void CreateNewJournal() {

    }
    public void CreateNewEntry() {

    }
}