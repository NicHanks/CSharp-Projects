
class IncrementalGoal : Goal
{
    //Attributes
    int _increment;
    int _IncremetAmount;
    string _name2;
    int _points2;
    string _done = "[ ]";
    //Constructors
    public IncrementalGoal(string goal, string name, int points, string name2, int points2) : base(goal, name, points)
    {
        _name2 = name2;
        _points2 = points2;
    }
    //Methods
    override public string GetStringRepresentation()
    {
        string str = $"{_done}|{_goal}|{_name}|{_points}|{_name2}|{_points2}";
        return str;
    }
    public override void MarkAsComplete()
    {
        Console.WriteLine("Have you completed the smaller goals 3 times? [Y/N] ");
        string u = Console.ReadLine();
        if (u == "Y")
        {
            _done = "[x]";
            _points += _points2*3;
        }
    }
}