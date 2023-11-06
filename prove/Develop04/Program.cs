using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        string input;
        do 
        {
            Console.WriteLine("Menu options:\n  1. Breathing Activity\n  2. Relfecting Activity \n  3. Listing Activity\n  4. Quit\nSelect a choice from the menu: ");
            input = Console.ReadLine();
            Console.Clear();
            if (input == "1")
            {
                BreathingActivity instance = new BreathingActivity("Breathing", "yolo", 0);
                instance.DisplayMessage();
                instance.DisplayStartingMessage();
                instance.DisplayCountDown();
                instance.DisplaySeriesOfMessages();
                instance.DisplayEndingMessage();
            } else if (input == "2")
            {
                ReflectingActivity reflecting = new ReflectingActivity("Reflecting", "yolo", 0);
                reflecting.DisplayMessage();
                reflecting.GetHowLong();
                reflecting.DisplayStartingMessage();
                //reflecting.PauseAnimation(); 
                reflecting.DisplayRandomQuestionsAndGetAnswers();
                reflecting.DisplayEndingMessage();

            } else if (input == "3")
            {
                ListingActivity listing = new ListingActivity("Listing", "yolo", 0); 
                listing.DisplayList();
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