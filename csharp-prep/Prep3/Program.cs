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
            response = Console.Read();
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
            } while (response != randomNumber);
        }
    }
}