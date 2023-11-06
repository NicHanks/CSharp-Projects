

class Shape
{
    //Attributes
    string _color;

    //Constructor
    public Shape(string color)
    {
        _color = color;
    }
    //Methods

    public string GetColor()
    {
        return _color;
    }
    public void SetColor(string x)
    {
        _color = x;
    }
    public virtual double GetArea(double x)
    {
        return x;
    }
}