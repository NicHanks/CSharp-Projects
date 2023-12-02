
using System.ComponentModel.DataAnnotations;

class Goal 
{
    //Attributes
    protected string _goal;
    protected string _name;
    protected int _points;
    //Constructor(s)
    public Goal(string goal, string name, int points)
    {
        _goal = goal;
        _name = name;
        _points = points; 
    }
    //Methods
    virtual public string GetStringRepresentation()
    {
        string str = $"{_goal} | {_name} | {_points}";
        return str;
    }
    public void DisplayAttribute()
    {

    }
    public void Write()
    {

    }
}