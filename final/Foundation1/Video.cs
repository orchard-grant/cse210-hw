public class Video
{
    private string _title { get; set; }
    private string _creator { get; set; }
    private int _duration { get; set; }
    private List<Comment> _comments { get; set; }

    public Video(string title, string creator, int duration)
    {
        _title = title;
        _creator = creator;
        _duration = duration;
        _comments = new List<Comment>();
    }

    // Public getter methods for private attributes
    public string GetTitle()
    {
        return _title;
    }

    public string GetCreator()
    {
        return _creator;
    }

    public int GetDuration()
    {
        return _duration;
    }

    public void AddComment(string name, string text)
    {
        _comments.Add(new Comment(name, text));
    }

    public int GetNumberOfComments()
    {
        return _comments.Count;
    }

    public List<Comment> GetComments()
    {
        return _comments;
    }
}

