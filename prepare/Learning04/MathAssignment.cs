
class MathAssignment : Assignments
{
    private string _textBookSection;
    private string _problems;

    //Constructor(s)
    public MathAssignment(string name, string topic, string sec, string prob) : base(name, topic)
    {
        _textBookSection = sec;
        _problems = prob;
    }

    //Methods
    public string GetHomeworkList()
    {
        return _textBookSection+" "+_problems;
    }
}