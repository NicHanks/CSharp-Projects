using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        string input;
        do 
        {
            Console.WriteLine("Menu options:\n  1. Breathing Activity\n  2. Relfecting Activity \n  3. Listing Activity\n  4. Dojo\n  5. Quit\nSelect a choice from the menu: ");
            input = Console.ReadLine();
            Console.Clear();
            if (input == "1")
            {
                BreathingActivity instance = new BreathingActivity("Breathing", "yolo", 0);
                instance.RunActivity();
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
                listing.RunActivity();
            } else if (input == "4")
            {
                Dojo d = new Dojo("Dojo", "yolo", 0); 
                d.RunActivity();
            }
        } while (input != "5");
       
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