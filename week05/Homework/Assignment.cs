// Assignment class
public class Assignment
{
    // attributes
    private string _studentName;
    private string _topic;

    // constructor
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    // getters
    public string GetStudentName()
    {
        return _studentName;
    }

    public string GetTopic()
    {
        return _topic;
    }

    // methods
    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }
}