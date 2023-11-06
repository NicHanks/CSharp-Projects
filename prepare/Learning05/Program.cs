using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning05 World!");

        List<Shape> _shapes = new List<Shape>();

        Square square = new Square("blue", 3);
        _shapes.Add(square);

        Rectangle rect = new Rectangle("green", 2, 4);
        _shapes.Add(rect);

        Circle cir = new Circle("yellow", 3.5);
        _shapes.Add(cir);

        foreach (Shape s in _shapes)
        {
            double area = s.GetArea(0); //the number is really just a place holder, it doesn't do anything. (It's because I used virtual not abstract in the base)
            string color = s.GetColor();

            Console.WriteLine($"The {color} shape has an area of {area}.");
        }
    }
}