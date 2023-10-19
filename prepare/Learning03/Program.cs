using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");
        Fraction f = new Fraction(3,4);
        Console.WriteLine(f.GetFractionString());
        Console.WriteLine(f.GetDecimalValue());

    }
}