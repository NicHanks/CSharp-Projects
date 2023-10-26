
public class Bookcase
{
    //attributes
    List<Book> _bookCase = new List<Book>();

    //constructor
    public Bookcase() 
    {
        _bookCase = new List<Book>();
    }

    //methods
    public void ShowBooks() 
    {
        foreach (Book line in _bookCase)
        {
            Console.WriteLine(line);
        }
    }
}