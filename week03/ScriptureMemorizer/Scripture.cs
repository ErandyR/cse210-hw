
public class Scripture
{
    private List<Word> _words = new List<Word>();
    private Reference _reference;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;

        string[] words = text.Split(" ");

        foreach (string word in words)
        {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWords(int numberToHide, Random random)
    {
        int wordCount = _words.Count;

        for (int i = 0; i < numberToHide; i++)
        {
            int index = random.Next(wordCount);
            _words[index].Hide();
        }
    }
    public string GetDisplayText()
    {
        string text = "";
        foreach (Word word in _words)
        {
            text += word.GetDisplayText() + " ";
        }
        return text;
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }

}