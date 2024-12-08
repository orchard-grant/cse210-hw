using System;
using System.Collections.Generic;

// Stores the contents of a comment, given username and feedback
public class Comment
{
    private string _username { get; set; }
    private string _feedback { get; set; }

    public Comment(string username, string feedback)
    {
        _username = username;
        _feedback = feedback;
    }

    // Public getter methods to access private attributes
    public string GetUsername()
    {
        return _username;
    }

    public string GetFeedback()
    {
        return _feedback;
    }
}
