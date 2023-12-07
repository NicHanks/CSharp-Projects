
using System.ComponentModel.DataAnnotations;

public class EternalGoal : Goal
{
    //Attributes
    string _goal;
    string _name;
    int _points;

    //Constructor
    public EternalGoal(string goal, string name, int points) : base(goal,name, points)
    {
        _goal = goal;
        _name = name;
        _points = points; 
    }

    //Methods
    public override void LoadGoal(string[] items)
    {
        base.LoadGoal(items);
        //_isComplete = bool.Parse(items[4]);
    }
}