using System;
using System.Collections.Generic;
using System.IO;

public class Prompt // prompt class for journal entry
{
    private Random _randomProducer = new Random(); // random number generator
    private List<string> _promptList = new List<string> // list of possible jounral entries
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "How did you practice self-care today?",
        "Write about a book or article that inspired you recently.",
        "What is a goal you want to achieve this week, and what steps will you take to reach it?",
        "If you could travel anywhere in the world, where would you go and why?",
        "What was the most surprising thing you learned today?",
        "How did you connect with someone today, and what was the outcome?",
        "What is one thing you wish you could change about your day?",
    };
    private int _selectedPromptIndex;

    public string GeneratePrompt() // method to generate prompt from the list
    {
        _selectedPromptIndex = _randomProducer.Next(_promptList.Count); // gets random
        return _promptList[_selectedPromptIndex]; // returns prompt
    }
}
