public class Resumes
{
    public string _name;
    // private List<Job> _jobs; //this creates a list of the data type List AND Job. 
    // _jobs = new List<Job>;
    public List<Job> _jobs = new List<Job>();
    // public Resumes(string x, List<Job> y)
    // {}
    public void Display()
    {
        Console.WriteLine($"Name: {_name}/nJobs: ");
        foreach (Job job in _jobs)
        {
            job.Display();
        }
    }

}

