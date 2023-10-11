public class Fraction 
{
    //attributs
    private int _top;
    private int _bottom;

    //constructor(s)
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }
    public Fraction(int wholenumber)
    {
        _top = wholenumber;
        _bottom = 1;
    }
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    public int GetTop()
    {
        return _top;
    }
    public void SetTop(int top)
    {
        _top = top;
    }
    public int GetBottom()
    {
        return _bottom;
    }
    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }
    public string GetFractionString()
    {
        return $"{_top.ToString()} / {_bottom.ToString()}";
    }
    public double GetDecimalValue()
    {
        return Convert.ToDouble(_top) / Convert.ToDouble(_bottom);
    }
}