
using System;

public class ListingActivity: FullActivity
{

    private Random _random = new Random();

    // Creates a list of questions for the user to respond to.
    private List<string> Prompts = new List<string>(){
        "Who is someone you looked up to?",
        "What is your biggest fear?",
        "Who are your closest friends?",
        "How have you improved this year?"
    };

    // Sets the name and description of the activity
     public ListingActivity()
    {
        SetActivityName("Listening Activity");
        SetDescription("This activity will help you practice listening.");
    }

    // Displays to the user instructions on how to complete the steps.
    public override void DisplayPrompt()
    {
        Console.WriteLine("List as many respones to the question as you can: ");
        Console.WriteLine($"--{Prompts[_random.Next(Prompts.Count)]}");
        Console.WriteLine("You can start in: ");
        UseTimer().CountDownFrom(5);
        Console.WriteLine();
    }

    // Sets up the time limit for this aspect of the program.
    private void ListOfThoughts()
    {
        DateTime future = UseTimer().GetFutureTime(GetDuration());
        int items = 0;

        while (!UseTimer().TimesUp(future))
        {
            Console.WriteLine("> ");
            Console.ReadLine();
            items++;
        }
    
        Console.WriteLine($"You wrote a total of {items} thoughts");
        UseTimer().LoadingScreen();
        Console.WriteLine();
    }
    // Calls the functions together.
    public override void StartActivity()
    {
        DisplayPrompt();
        ListOfThoughts();
    }
}
