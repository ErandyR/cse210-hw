

using Microsoft.VisualBasic;

public class Entry
{
    public string _date;

    public string _propmtText;

    public string _entryText;


    public void Display()
    {
        Console.WriteLine($"My prompt was: {_propmtText}");
        Console.WriteLine($"My response was: {_entryText}");
        Console.WriteLine($"Date: {_date}");
    }
}