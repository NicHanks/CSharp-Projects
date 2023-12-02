
class IncrementalGoal : Goal
{
    //Attributes
    int _increment;
    int _IncremetAmount;
    //Constructors
    public IncrementalGoal(string goal, string name, int points) : base(goal, name, points)
    {

    }
    //Methods
    override public string GetStringRepresentation()
    {
        string str = $"{_goal} | {_name} | {_points}";
        return str;
    }

}