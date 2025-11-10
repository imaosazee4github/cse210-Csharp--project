using System;

//Entry Class
class Entry{
    public string _date;
    public string _promptText;
    public string _entryText;
    public int _mood;

    public void Display()
    {
        Console.WriteLine($"{_date} - Mood: {_mood}/10");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine(_entryText);
        Console.WriteLine();
    }
}