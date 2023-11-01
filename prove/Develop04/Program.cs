using System;

class Program
{
    static void Main(string[] args)
    {
        string input;
        do 
        {
        Console.WriteLine("Menu options:\n  1. Breathing Activity\n  2. Relfecting Activity \n  3. Listing Activity\n  4. Quit\nSelect a choice from the menu: ");
        input = Console.ReadLine();
        if (input == "1")
        {
            BreathingActivity instance = new BreathingActivity();
            instance.DisplayMessage();
            instance.DisplayCountDown();
            instance.DisplaySeriesOfMessages();
        } else if (input == "2")
        {
            ReflectingActivity reflecting = new ReflectingActivity();
            reflecting.DisplayList();

        } else if (input == "3")
        {
            //ListingActivity listing = new ListingActivity(); 
        }
        } while (input != "4");
        
    }

    public void CallAnimation(int time)
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(time);

        //Thread.Sleep(3000);

        DateTime currentTime = DateTime.Now;
        if (currentTime < futureTime)
        {
            Console.WriteLine("We have not arrived at our future time yet...");
        }
    }
}