
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
    public void DisplayMessage()
    {
        Console.WriteLine($"Welcome to the {_activity} activity!\n\n{_descriptionOfActivity}\n");
    }
    public void DisplaySeriesOfMessages()
    {
        //"Breathe in..."
        //"Breathe out..."
    }
    public void DisplayCountDown()
    {

    }
}