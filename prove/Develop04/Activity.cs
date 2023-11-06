
class Activity
{
    //Attributes
    public string _activityName;
    public string _description;
    private int _durationInSec;


    //Constructor(s)
    public Activity(string activityname, string description, int duration)
    {
        
    }
    //Methods
    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine("\nGet ready...\n");
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done! :D");
    }
    public void PauseAnimation()
    {
        for (int i =0; i > 6; i++)
        {
            Console.Write("+");
            Thread.Sleep(20000);
            Console.Write("\b \b"); 
            Console.Write("-");
        }

    }
    public void PauseAndShowSpinner()
    {
        
    }
    public void PauseAndShowTimer()
    {
        
    }

}