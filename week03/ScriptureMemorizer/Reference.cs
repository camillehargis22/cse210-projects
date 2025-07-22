// Reference class
public class Reference
{
    // attributes
    private string _book;
    private int _chapter;
    private int _verse;
    private int _lastVerse;

    // constructors
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _lastVerse = -1;
    }

    public Reference(string book, int chapter, int verse, int lastVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _lastVerse = lastVerse;
    }

    // methods
    // Displays reference
    public string GetDisplayText()
    {
        if (_lastVerse == -1)
        {
            // display for one verse
            return $"{_book} {_chapter}:{_verse}";
        }
        else
        {
            // display for multiple verses
            return $"{_book} {_chapter}:{_verse}-{_lastVerse}";
        }
    }
}