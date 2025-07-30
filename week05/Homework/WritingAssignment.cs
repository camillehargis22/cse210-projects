// Writing Assignment class
// inherits Assignment class
public class WritingAssignment : Assignment
{
    // attributes
    private string _title;

    // constructor
    public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic)
    {
        _title = title;
    }

    // methods
    public string GetWritingInformation()
    {
        return $"{_title} by {GetStudentName()}";
    }
}