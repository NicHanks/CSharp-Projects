
class BigGoal : Goal
{
    //Attributes
    protected string _goal;
    protected string _name;
    protected int _points;
    int _numberOfSteps;
    //Constructors
    public BigGoal(string goal, string name, int points) : base(goal, name, points)
    {
        _goal = goal;
        _name = name;
        _points = points;
    }
    //Methods
    public override string GetStringRepresentation()
    {
        string str = $"{_goal} | {_name} | {_points}";
        return str;
    }
}