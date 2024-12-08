public class Program
{
    public static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Understanding C# Basics", "Alice Johnson", 900);
        video1.AddComment("JohnDoe123", "This really helped me understand C#!");
        video1.AddComment("CodeLover98", "Great explanation and examples.");
        video1.AddComment("TechieTom", "Clear and concise. Thanks!");
        videos.Add(video1);

        Video video2 = new Video("Advanced C# Techniques", "Robert Smith", 679);
        video2.AddComment("DevGuru", "The examples were spot on.");
        video2.AddComment("SarahCSharp", "This is exactly what I needed to level up my skills.");
        video2.AddComment("CodingPro7", "Looking forward to more content like this.");
        videos.Add(video2);

        Video video3 = new Video("C# for Beginners: A Complete Guide", "Emily Davis", 408);
        video3.AddComment("NewbieCoder", "Perfect for someone just starting out.");
        video3.AddComment("LearningGeek", "I wish I had seen this video sooner!");
        video3.AddComment("FriendlyDev", "Great resource, but I wish it included more examples.");
        videos.Add(video3);

        foreach (Video video in videos)
        {
            // Updated to use getter methods instead of direct attribute access
            Console.WriteLine("Title: " + video.GetTitle());
            Console.WriteLine("Author: " + video.GetCreator());
            Console.WriteLine("Length: " + video.GetDuration() + " seconds");
            Console.WriteLine("Number of Comments: " + video.GetNumberOfComments());

            Console.WriteLine("Comments:");
            foreach (Comment comment in video.GetComments())
            {
                // Updated to use getter methods in the Comment class
                Console.WriteLine($"- {comment.GetUsername()}: {comment.GetFeedback()}");
            }

            Console.WriteLine();
        }
    }
}
