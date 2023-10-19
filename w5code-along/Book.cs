public class Book {
    //attributes
    private string _author;
    private string _name;
    private int _timesRead;
    private Boolean _available;

    //methods

    public Book(string name, string author) {
        _name = name;
        _author = author;
        _timesRead = 0;
        _available = true;
    }

    public void Display() {
        Console.WriteLine(_name);
        Console.WriteLine(_author);
        Console.WriteLine(_available);
        Console.WriteLine(_timesRead);
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