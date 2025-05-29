
public class Scripture
{
    private List<Word> _words = new List<Word>();
    private Reference _reference;

    public Scripture(Reference reference, string text)
    {

    }

    public void HideRandomWords()
    {
        int numberToHide = 0;
        Console.WriteLine($"{numberToHide}");
    }

    public string GetDisplaText()
    {
        string text = "";
        return text;
    }

    public bool IsCompletelyHidden()
    {
        return true;
    }

}