

class Circle : Shape
{
    //Attributes
    double _radius;
    //Constructor
    public Circle(string color, double x) : base(color)
    {
    }
    //Methods
    public override double GetArea(double x)
    {
        double y = _radius * _radius * 3.14;
        return y;
    }
}