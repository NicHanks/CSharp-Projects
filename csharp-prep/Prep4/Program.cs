using System;
using System.Net;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep4 World!");
        // List<int> numbers = [3, 8, 9, 2];
        // List<string> words = ["yolo", "heyy", "hhi"];
        // List<int> nub;
        // nub = new List<int>();
        // Console.WriteLine(nub);
        // numbers.Add(3);

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int webResponse = 0;
        List<int> numList;
        numList = new List<int>();

        do
        {
            Console.Write("Enter number: ");
            webResponse = Console.Read();
            numList.Add(webResponse);

        } while (webResponse != 0);

        int sum = numList.Sum();
        double average = numList.Average();
        int largestNum = numList.Max();

        Console.Write($"The sum is: {sum}");
        Console.Write($"The average is: {average}"); 
        Console.Write($"  The largest number is: {largestNum}");    

    }
}