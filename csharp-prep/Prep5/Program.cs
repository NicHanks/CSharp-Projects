using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Program!");
        string userName = GetName();
        string num = GetNumber();
        int numb = int.Parse(num);
        string square = GetSquared(numb);
        int squared = int.Parse(square);
        DisplayResult(userName, squared);


        static string GetName()
        {
            Console.Write("What is your name? ");
            string userName = Console.ReadLine();
            return userName;
        }
        static string GetNumber()
        {
            Console.Write("Please enter your favorite number: ");
            string number = Console.ReadLine();
            int numberr = int.Parse(number);
            return number;
        }
        static string GetSquared(int numm)
        {
            int num = numm * numm;
            string nummm = num.ToString();
            return nummm;
        }

        static void DisplayResult(string name, int square)
        {
            Console.WriteLine($"{name}, the square of your number is {square}.");
        }
        



    }
}