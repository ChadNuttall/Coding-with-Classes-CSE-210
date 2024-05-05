using System;
using System.IO;


class Entry
{
    public string _name;
    public string _date;
    public string _promptText;
    public string _entryText;

    public Entry(string name, string date, string prompt, string entryText)
    {
        _name = name;
        _date = date;
        _promptText = prompt;
        _entryText = entryText;
    }
}