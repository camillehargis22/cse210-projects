// Video class
public class Video
{
    // attributes
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments;

    // constructor
    public Video(string title, string author, int length, List<Comment> comments)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = comments;
    }

    // methods
    public int NumberOfComments()
    {
        return _comments.Count;
    }

    public string GetDisplayText()
    {
        string text = $"Title: {_title}\nAuthor: {_author}\nLength: {_length} seconds\nNumber of Comments: {NumberOfComments()}\n";
        foreach (Comment comment in _comments)
        {
            text = text + comment.GetDisplayText() + "\n";
        }

        return text;
    }
}