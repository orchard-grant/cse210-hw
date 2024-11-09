using System;

public class FullActivity
{
    private string _activityName;  // Holds the name of the activity
    private string _description;   // Holds the description of the activity
    private int _duration;         // Holds the duration of the activity
    private Timer _time = new Timer();  // Timer instance to manage time-related actions

    public FullActivity()
    {
        // Default constructor
    }

    // Virtual method for displaying the activity prompt (to be overridden in derived classes)
    public virtual void DisplayPrompt() { }

    // Virtual method to start the activity (to be overridden in derived classes)
    public virtual void StartActivity() { }

    // Sets the name of the activity
    public void SetActivityName(string activityName)
    {
        _activityName = activityName;
    }

    // Gets the name of the activity
    public string GetActivityName()
    {
        return _activityName;
    }

    // Sets the description of the activity
    public void SetDescription(string description)
    {
        _description = description;
    }

    // Gets the description of the activity
    public string GetDescription()
    {
        return _description;
    }

    // Sets the duration of the activity (in seconds)
    public void SetDuration(int duration)
    {
        _duration = duration;
    }

    // Gets the duration of the activity (in seconds)
    public int GetDuration()
    {
        return _duration;
    }

    // Sets up the activity by displaying information and initializing the timer
    public void ActivitySetup()
    {
        Console.Write($"Welcome to the {_activityName}.\n");
        _time.LoadingScreen();  // Display loading animation
        Console.WriteLine(_description);  // Display activity description
        Console.WriteLine("How long, in seconds, would you like for your session?");
        _duration = Int32.Parse(Console.ReadLine());  // Get session duration from user

        Console.Clear();

        Console.Write("Get ready...");
        _time.CountDownFrom(4);  // Countdown before the activity begins
        Console.Clear();
        Thread.Sleep(500);  // Small delay before activity starts
    }

    // Marks the end of the activity and displays a completion message
    public void FinishActivity()
    {
        Console.WriteLine("Well Done!!");
        Console.WriteLine($"You have finished {_duration} seconds of the {_activityName}");
        _time.LoadingScreen();  // Display loading animation

        Console.Clear();
    }

    // Returns the timer instance used in the activity
    public Timer UseTimer()
    {
        return _time;
    }
}
