// Word class
public class Word
{
    // attributes
    private string _word;
    private bool _isHidden;

    // constructor
    public Word(string word)
    {
        _word = word;
        _isHidden = false;
    }

    // methods
    public void Hide()
    {
        _isHidden = true;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
        if (_isHidden)
        {
            string text = "";
            for (int i = 0; i < _word.Count(); i++)
            {
                text = text + "_";
            }
            return text;
        }
        else
        {
            return _word;
        }
    }
}