

class Square : Shape
{
    //Attributes
    double _side;

    //Constructor
    public Square(string color, double side) : base(color)
    {
    }

    //Methods
    public override double GetArea(double x)
    {
        double area = _side * _side;
        return area;
    }
}