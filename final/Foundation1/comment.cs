using System;
using System.Collections.Generic;

// stores the contents of a comment, given username and feedback
public class Comment
{
    public string Username { get; set; }
    public string Feedback { get; set; }

    public Comment(string username, string feedback)
    {
        Username = username;
        Feedback = feedback;
    }
}