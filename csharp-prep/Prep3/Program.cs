using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int randomNumber = randomGenerator.Next(1,101);
        int response = 0;
        do
        {
            Console.Write("What is your guess? ");
            string response1 = Console.ReadLine();
            response = int.Parse(response1);
            if (response == randomNumber){
                Console.WriteLine("You guessed it!");
            } 
            else if (response > randomNumber)
            {
            Console.WriteLine("Lower");
            } 
            else
            {
            Console.WriteLine("Higher");
            } 
        } while (response != randomNumber);
    }
}

