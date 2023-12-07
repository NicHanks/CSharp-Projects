public abstract class Goal
{
    //Attributes
    protected string _goal;
    protected string _name;
    protected string _description;
    protected int _points;
    protected string _done = "[ ]";

    //Constructor
    public Goal(string goal, string name, int points)
    {
        _goal = goal;
        _name = name;
        _points = points; 
    }

    public virtual void LoadGoal(string[] items)
    {  
        _goal = items[0];
        _name = items[1];
        _description = items[2];
        _points = int.Parse(items[3]);
    }
    public virtual string GetStringRepresentation()
    {
        string str = $"{_done}|{_goal}|{_name}|{_points}";
        return str;
    }
    public virtual void MarkAsComplete()
    {
        _done = "[x]";
    }
    public virtual string GetDone()
    {
        return _done;
    }
    public virtual int GetPoints()
    {
        return _points;
    }
}