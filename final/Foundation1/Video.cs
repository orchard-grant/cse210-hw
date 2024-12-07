public class Video
{
    public string Title { get; set; }
    public string Creator { get; set; }
    public int Duration { get; set; }
    private List<Comment> Comments { get; set; }

    public Video(string title, string creator, int duration)
    {
        Title = title;
        Creator = creator;
        Duration = duration;
        Comments = new List<Comment>();
    }

    public void AddComment(string name, string text)
    {
        Comments.Add(new Comment(name, text));
    }

    public int GetNumberOfComments()
    {
        return Comments.Count;
    }

    public List<Comment> GetComments()
    {
        return Comments;
    }
}

