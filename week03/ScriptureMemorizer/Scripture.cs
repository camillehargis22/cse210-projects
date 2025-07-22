// Scripture class
public class Scripture
{
    // attributes
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    // constructor
    public Scripture(Reference reference, string scripture)
    {
        _reference = reference;
        List<string> list = scripture.Split(" ").ToList();
        foreach (string item in list)
        {
            Word word = new Word(item);
            _words.Add(word);
        }
    }

    public string GetDisplayText()
    {
        string text = _reference.GetDisplayText();
        foreach (Word word in _words)
        {
            text = text + " " + word.GetDisplayText();
        }

        return text;
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();

        for (int i = 0; i < numberToHide; i++)
        {
            int randomIndex = random.Next(0, _words.Count);
            _words[randomIndex].Hide();
        }
    }

    public bool AllWordsHidden()
    {
        int count = 0;
        foreach (Word word in _words)
        {
            if (word.IsHidden())
            {
                count++;
            }
        }
        if (count == _words.Count)
        {
            return true;
        }
        return false;
    }
}