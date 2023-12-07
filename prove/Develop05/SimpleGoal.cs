
using System.ComponentModel.DataAnnotations;

public class SimpleGoal : Goal
{
    //Attributes
    string _goal;
    string _name;
    int _points;

    //Constructor
    public SimpleGoal(string goal, string name, int points) : base(goal,name, points)
    {
        _goal = goal;
        _name = name;
        _points = points; 
    }

    //Methods

    // public override void LoadGoal(string[] items)
    // {
    //     base.LoadGoal(items);
    //     _bonusPoints = int.Parse(items[4]);
    //     _timesCompleted = int.Parse(items[5]);
    //     _total = int.Parse(items[6]);
    // }
    public override void LoadGoal(string[] items)
    {
        base.LoadGoal(items);
        //_isComplete = bool.Parse(items[4]);
    }
    // GetStringRepresentation should still work when called because it's public virual under base.
    // virtual public string GetStringRepresentation()
    // {
    //     string str = $"{_done}|{_goal}|{_name}|{_points}";
    //     return str;
    // }
}