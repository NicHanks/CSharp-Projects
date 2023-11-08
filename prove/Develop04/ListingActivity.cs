using System;

class ListingActivity : Activity
{
    //Attributes
    string _activityName;
    List<string> _list = new List<string>();
    private string _discriptionOfActvity = "Welcome to the Listing Activity!\n\nThis activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.\n\nHow long, in seconds, would you like your session to be? ";
    private List<string> _listOfPrompts = new List<string> 
    {"Who are people that you appreciate?",
    "What are personal strengths of yours?",
    "Who are people that you have helped this week?",
    "When have you felt the Holy Ghost this month?",
    "Who are some of your personal heroes? "};
    //Constructor(s)
    public ListingActivity(string activityname, string description, int duration) : base(activityname, description, duration)
    {
        _activityName = "Listing";
        // _description = "This activity will help you reflect on times ...";
        // _duration = 50;
    }
    //Methods
    public void RunActivity()
    {
        DisplayMessage();
        DisplayStartingMessage();
        DisplayRandomPrompt();
        Thread.Sleep(10000);
        CreateList();
        DisplayEndingMessage();
    }
    public void DisplayMessage()
    {
        Console.WriteLine($"Welcome to the {_activityName} activity!\n\n{_discriptionOfActvity}");
    }
    public void DisplayRandomPrompt()
    {
        Random r = new Random();
        int n = r.Next(0,4);
        Console.WriteLine(_listOfPrompts[n]);
    }
    public void CreateList()
    {
        string x = Console.ReadLine();
        _list.Add(x);
    }
    public void DisplayList()
    {
        foreach (string i in _list)
        {
            Console.Write(i);
        }
    }

}