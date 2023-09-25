public class Job 
{
    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;


    // public Job(string x, string y, int i, int e)
    // {
    //     string _company = x;
    //     string _jobTitle = y;
    //     int _startYear = i;
    //     int _endYear = e;
    // }
    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}