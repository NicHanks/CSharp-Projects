public class Book : Loanable 
{
    //attributes
    private string _author;
    private string _title;
    private int _timesRead;
    private Boolean _available;
    //private string _isbn;
    //private long _upc;

    //methods

    public Book(string title, string author) 
    {
        _title = title;
        _author = author;
        _timesRead = 0;
        _available = true;
    }

    public override void Display() 
    {
        ShowbookDetails();
    }
    public void ShowbookDetails()
    {
        Console.WriteLine(_title);
        Console.WriteLine(_author);
        Console.WriteLine(_available);
        Console.WriteLine($"Times read: {_timesRead}");
    }
    public bool IsAvailable() 
    {
        return _available;
    }
    public int TimesRead() 
    {
        return _timesRead;
    }
    public void CheckOut() 
    {
        _timesRead += 1;
        _available = true;
    }
    public void CheckIn() 
    {
        _available = true;
    }
    public bool HasAuthor(string author)
    {
        return _author.Contains(author);
    }
}