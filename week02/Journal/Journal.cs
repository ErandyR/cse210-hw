using System.IO;
public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public string _filename;

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);

    }
    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(Entry entry)
    {

        using (StreamWriter outputFile = new StreamWriter(_filename))
        {
            outputFile.WriteLine(entry._propmtText);
            outputFile.WriteLine(entry._entryText);
            outputFile.WriteLine(entry._date);
        }
    }

    public void LoadFromFile()
    {

        string[] lines = System.IO.File.ReadAllLines(_filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");

            string firstName = parts[0];
            string lastName = parts[1];
        }
    }
}
