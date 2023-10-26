
class Assignments
{
    // Attributes
    protected string _studentName = "Unknown";
    private string _topicString = "Topic";

    // Constructors
    public Assignments() 
    {
        
    }
    public Assignments(string name, string topic)
    {
        _studentName = name;
        _topicString = topic;
    }
    public string GetSummery()
    {
        string summery = _studentName+" - "+_topicString;
        return summery;
    }
}