class Dojo : Activity
{

    public Dojo(string activityname, string description, int duration) : base(activityname, description, duration)
    {

    }

    public void RunActivity()
    {
        Console.WriteLine("Dance for 30 seconds!");
        Thread.Sleep(30000);
    }
}