
class BreathingActivity : Activity
{
    //think video shows that it should be 15 sec
    //Attributes    private string _activity;
    private string _activity;
    private string _descriptionOfActivity = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.\n\nHow long, in seconds, would you like your session to be? ";

    //Constructor(s)
    public BreathingActivity(string activityname, string description, int duration) : base(activityname, description, duration)
    {
        _activity = activityname;
        
    }
    //Methods
    public void RunActivity()
    {
        DisplayMessage();
        DisplayStartingMessage();
        DisplayCountDown();
        Thread.Sleep(3000);
        DisplaySeriesOfMessages();
        DisplayEndingMessage();
    }
    public void DisplayMessage()
    {
        Console.WriteLine($"Welcome to the {_activity} activity!\n\n{_descriptionOfActivity}\n");
    }
    public void DisplaySeriesOfMessages()
    {
        for (int i = 0; i < 4; i++)
        {
            Console.WriteLine("Breathe in...");
            Thread.Sleep(4000);
            Console.WriteLine("Breathe out...");
            Thread.Sleep(4000);
        }
    }
    public void DisplayCountDown()
    {
        for (int i = 0; i < 3; i++)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");

        }

    }
}