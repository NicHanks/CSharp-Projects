using System;

class Program
{
    static void Main(string[] args)
    {
        // learning program 4 Activity
        Console.WriteLine("Hello Learning04 World!");
        Assignments bennet = new Assignments("Samuel Bennet", "Multiplication");
        Console.WriteLine(bennet.GetSummery());
        MathAssignment mulath = new MathAssignment("Roberto Rodriguez", "Fractions", "Section 7.3", "Problem 8-19");
        Console.WriteLine(mulath.GetSummery());
        Console.WriteLine(mulath.GetHomeworkList());
        WritingAssignment eng = new WritingAssignment("Mary Waters", "European History", "The Causes of Work War II");
        Console.WriteLine(eng.GetSummery());
        Console.WriteLine(eng.GetWritingInformation());

    }
}