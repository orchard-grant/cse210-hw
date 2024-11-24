using System;

class ChecklistGoal : Base
{
    public string GoalCount; // Number of times the goal must be completed to earn bonus points
    public string BonusPoints; // Bonus points 

    // Constructor
    public ChecklistGoal()
    {
        
    }

    // Override method
    public override void GetValues()
    {
        base.GetValues(); // Call the base class implementation
    }

    // Method
    public void GetBonusPoints()
    {
        // Ask the user how many completions are required for bonus points
        Console.WriteLine("How many times do you want to complete this goal before receiving bonus points?");
        GoalCount = Console.ReadLine(); // Store user input for the required completions

        // Ask the user for the number of bonus points they want to assign
        Console.WriteLine("How many bonus points do you want for completing the goal?");
        BonusPoints = Console.ReadLine(); // Store user input for the bonus points
    }
}
