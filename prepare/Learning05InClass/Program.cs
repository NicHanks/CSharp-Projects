using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        string user = "";
        while (user != "4")
        {
            //Console.WriteLine("Hello Develop05 World!");
            Console.WriteLine("to turn on press[1]");
            Console.WriteLine("to turn off press[2]");
            Console.WriteLine("to get time press[3]");
            Console.WriteLine("to exit press[4]");
            user = Console.ReadLine();
            SmartDevice device1 = new SmartDevice();
            if (user == "1")
            {
                device1.TurnOn();
                Thread.Sleep(5000);
            } else if (user == "2")
            {
                device1.TurnOff();
            } else if (user == "3")
            {
                device1.GetTime();
            }
        }
    }
}