
// journal class
public class Journal
{
    private List<Entry> _entryList = new List<Entry>(); // list to store journal entries

    public void Initialize() // method to make journal
    {
        _entryList = new List<Entry>();
    }

    public void AppendEntry(Entry e) // method to add journal entry
    {
        _entryList.Add(e);
    }

    public void Display() // method to display journal entry
    {
        foreach (var entry in _entryList)
        {
            entry.Display();
        }
    }
    public void SaveToFile(string filename) // method to save journal to file
{
    using (StreamWriter writer = new StreamWriter(filename))
    {
        foreach (var entry in _entryList)
        {
            writer.WriteLine($"{entry.GivenPrompt}|{entry.EntryDateTime}|{entry.EntryText}"); // format it correclty
        }
    }
    Console.WriteLine("Journal saved successfully.");
}

public void LoadFromFile(string filename) // method to load to file
{
    if (File.Exists(filename))
    {
        _entryList.Clear();
        string[] lines = File.ReadAllLines(filename);
        foreach (var line in lines)
        {
            string[] parts = line.Split('|');
            if (parts.Length == 3)
            {
                string prompt = parts[0];
                string dateTime = parts[1];
                string entryText = parts[2];
                Entry entry = new Entry(prompt, dateTime, entryText);
                _entryList.Add(entry);
            }
        }
        Console.WriteLine("Journal loaded successfully."); // message to confirm load
    }
    else
    {
        Console.WriteLine("File not found."); // error if not found
    }
}

}
