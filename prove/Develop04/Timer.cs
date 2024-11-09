using System;
using System.Threading;
using System.Collections.Generic;

public class Timer
{
    // Constructor: Initializes Timer (no specific setup currently)
    public Timer()
    {

    }

    // Displays a loading animation for 5 seconds
    public void LoadingScreen()
    {
        List<string> animationStrings = new List<string>() { "|", "/", "-", "\\", "|", "/", "-", "\\" };

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(5);

        while (DateTime.Now < endTime)
        {
            foreach (string s in animationStrings)
            {
                Console.Write(s);
                Thread.Sleep(500);
                Console.Write("\b \b");
            }
        }
    }

    // Counts down from a given number, printing each number with a 1-second delay
    public void CountDownFrom(int num)
    {
        for (int i = num; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    // Returns a future time, 'seconds' seconds from the current time
    public DateTime GetFutureTime(int seconds)
    {
        DateTime startTime = DateTime.Now;
        return startTime.AddSeconds(seconds);
    }

    // Checks if the current time has passed the specified future time
    public bool TimesUp(DateTime futureTime)
    {
        return DateTime.Now > futureTime;
    }
}
