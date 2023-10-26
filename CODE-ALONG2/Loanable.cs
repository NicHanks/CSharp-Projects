
public class Loanable
{
    protected bool _isCheckedIn = true;
    //private string _title;

    public void Checkout()
    {
        _isCheckedIn = false;
    }
    public virtual void Display()
    {
        Console.WriteLine($"Available: {_isCheckedIn}");
    }
}