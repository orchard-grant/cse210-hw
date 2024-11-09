
using System;

public class ReflectingActivity : FullActivity
{
    // Calls the random function, and creates a list of Prompts for the user.
    private Random _random = new Random();
    private List<string> Prompts = new List<string>(){
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    // Creates a second list of follow up questions for the user.
    private List<string> QuestionPrompt = new List<string>(){
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"};

    // Sets the name and description of the activity
    public ReflectingActivity()
    {
        SetActivityName("Reflecting Activity");
        SetDescription("This activity will help you reflect on questions that will be provided to you.");
    }
    // Display the instructions to the user.
    public override void DisplayPrompt()
    {
        Console.WriteLine("Take time to ponder on the questions that will be provided to you: ");
        Console.WriteLine($"--{Prompts[_random.Next(Prompts.Count)]}");
        Console.WriteLine("You can start in: ");
        UseTimer().CountDownFrom(5);
        Questions();
    }

    // Prints the random question and prints the loading screen.
    private void Questions()
    {
        int numQuestions = (GetDuration() / 10) + 1;

        for (int i = 0; i < numQuestions; i++)
        {
            Console.Write(">" + QuestionPrompt[_random.Next(QuestionPrompt.Count)]);
            UseTimer().LoadingScreen();
            Console.WriteLine();
        }
    }
    
    public override void StartActivity()
    {
        DisplayPrompt();
    }

}
