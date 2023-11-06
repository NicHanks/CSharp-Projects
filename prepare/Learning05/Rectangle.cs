

class Rectangle : Shape
{
    //Attributes
    double _length;
    double _width;
    //Constructor
    public Rectangle(string color, double h, double w) : base(color)
    {
        _length = h;
        _width = w;
    }
    //Methods
    public override double GetArea(double x)
    {
        return _length * _width;
    }
}