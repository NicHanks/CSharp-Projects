// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


// Book hp = new Book("harry Potter", "JK Rowling");
// hp.Display();
using System;
class Program
{
    static void Main(string[] args)
    {
        Book harryPotter = new Book("Harry", "zandra");
        harryPotter.Display();
        Book cats = new Book("cats", "Murphy");
        cats.CheckOut();
        cats.Display();
        Dvd gIJoe = new Dvd("GI Joe");
        gIJoe.Display();
    }
}