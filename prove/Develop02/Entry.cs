using System;

public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

    public Entry(string date, string prompt, string textEntry)
    {
        _date = date;
        _promptText = prompt;
        _entryText = textEntry;
    }
    
    public void Display()
    {
        Console.WriteLine($"{_date}, {_promptText}, {_entryText}");

    }
}