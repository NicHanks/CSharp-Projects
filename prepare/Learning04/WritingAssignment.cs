
class WritingAssignment : Assignments
{
    private string _title;
    public WritingAssignment(string name, string topic, string info) : base(name, topic)
    {
        _title = info;
    }
    public string GetWritingInformation()
    {
        return _title+" by "+_studentName;
    }

}