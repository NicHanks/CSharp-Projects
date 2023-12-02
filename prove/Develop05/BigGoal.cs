
class BigGoal : Goal
{
    //Attributes
    
    int _numberOfSteps;
    //Constructors
    public BigGoal(string goal, string name, int points) : base(goal, name, points)
    {

    }
    //Methods
    override public string GetStringRepresentation()
    {
        string str = $"{_goal} | {_name} | {_points}";
        return str;
    }
}