using System;
using System.IO;

class Journal
{
    private List<Entry> _entries;    

    public void AddEntry(string name, string prompt, string entryText)
    {
        _entries = new List<Entry>();
        Entry entry = new Entry(name, DateTime.Now.ToShortDateString(), prompt, entryText);
        _entries.Add(entry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            Console.WriteLine($"\nName: {entry._name}\nDate: {entry._date} - Prompt: {entry._promptText}\n{entry._entryText}\n");
        }
    }

    public void SaveToFile(string fileName)
    {
        using (StreamWriter saveEntry = new StreamWriter(fileName))
        {
            foreach (Entry entry in _entries)
            {
                saveEntry.WriteLine($"{entry._name},{entry._date},{entry._promptText},{entry._entryText}");
            }
        }
    }

    public void LoadFromFile(string fileName)
    {
        _entries = new List<Entry>();

        using (StreamReader reader = new StreamReader(fileName))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split(',');
                if (parts.Length == 4)
                {
                    string name = parts[0];
                    string date = parts[1];
                    string prompt = parts[2];
                    string entryText = parts[3];
                    
                    _entries.Add(new Entry(name, date, prompt, entryText));
                }
            }
        }
    }
}