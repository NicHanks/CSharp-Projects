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
        int response = 1;
        List<int> numList;
        numList = new List<int>();

        while (response != 0)
        {
            Console.Write("Enter number: ");
            string userInput = Console.ReadLine();
            if (int.TryParse(userInput, out int parsedResponse))
            {
                response = parsedResponse;
                if (response != 0)
                {
                numList.Add(response);
                }

            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }

        } 

        int sum = numList.Sum();
        double average = numList.Average();
        int largestNum = numList.Max();

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}"); 
        Console.WriteLine($"The largest number is: {largestNum}");    

    }
}