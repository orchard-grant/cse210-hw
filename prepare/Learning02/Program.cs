using System;
using System.Threading.Tasks.Dataflow;


public class Job
{
    public string JobTitle { get; set; }
    public string Company { get; set; }
    public int StartYear { get; set; }
    public int EndYear { get; set; }

    public void DisplayJob()
    {
        Console.WriteLine($"{JobTitle} at {Company} ({StartYear} - {EndYear})");
    }
}

public class Resume
{
    public string Name { get; set; }
    public List<Job> Jobs { get; set; } = new List<Job>();

    public void DisplayResume()
    {
        Console.WriteLine($"Resume for: {Name}");
        Console.WriteLine("Job History:");

        foreach (Job job in Jobs)
        {
            job.DisplayJob();
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
         Job job1 = new Job
        {
            JobTitle = "Phones Specialist",
            Company = "BYU-Idaho",
            StartYear = 2022,
            EndYear = 2023
        };

        Job job2 = new Job
        {
            JobTitle = "Hiring Manager",
            Company = "BYU-Idaho",
            StartYear = 2023,
            EndYear = 2024
        };

        Resume myResume = new Resume
        {
            Name = "Grant Orchard"
        };
        myResume.Jobs.Add(job1);
        myResume.Jobs.Add(job2);

        myResume.DisplayResume();
    }
}