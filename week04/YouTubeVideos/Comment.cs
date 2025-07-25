// Comment class
public class Comment
{
    // attributes
    private string _name;
    private string _comment;

    // constructor
    public Comment(string name, string comment)
    {
        _name = name;
        _comment = comment;
    }

    public string GetDisplayText()
    {
        return $"Name: {_name}\nComment: {_comment}";
    }
}