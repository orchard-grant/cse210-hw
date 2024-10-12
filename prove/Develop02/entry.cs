using System;
using System.Collections.Generic;
using System.IO;

public class Entry // class representing journal entry

{
    
    //Attributes
public string GivenPrompt { get; private set; }
public string EntryDateTime { get; private set; }
public string EntryText { get; private set; }

    //Methods
    public Entry(string prompt, string dateTime, string text) // creates new prompt, date/time, text
    {
        GivenPrompt = prompt;
        EntryDateTime = dateTime;
        EntryText = text;
    }

    //Method to display entry
    public void Display()
    {
        Console.WriteLine($"{EntryDateTime} - {GivenPrompt}: {EntryText}");
    }

}