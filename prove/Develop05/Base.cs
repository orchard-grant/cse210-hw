using System;
using System.Collections.Generic;

class Base
{
    // Properties for goal details
    public string GoalName { get; set; }
    public string GoalDescription { get; set; }
    public int PointValue { get; set; }
    public int PointTotal { get; set; }

    // Shared list of goals across instances
    public static List<Base> GoalList = new List<Base>();

    // Default constructor
    public Base()
    {
    }

    // Displays the goal creation menu and processes user input
    public void goalMenu()
    {
        Console.WriteLine("----------------------");
        Console.WriteLine("1. Create new Simple Goal");
        Console.WriteLine("2. Create new Eternal Goal");
        Console.WriteLine("3. Create new Check List Goal");
        Console.WriteLine("----------------------");

        int userInput = int.Parse(Console.ReadLine());

        if (userInput == 1)
        {
            SimpleGoal simpleGoal = new SimpleGoal();
            simpleGoal.GetValues();
            GoalList.Add(simpleGoal); // Add Simple Goal to the list
        }
        else if (userInput == 2)
        {
            EternalGoal EternalGoal = new EternalGoal();
            EternalGoal.GetValues();
            GoalList.Add(EternalGoal); // Add Eternal Goal to the list
        }
        else if (userInput == 3)
        {
            ChecklistGoal ChecklistGoal = new ChecklistGoal();
            ChecklistGoal.GetValues();
            ChecklistGoal.GetBonusPoints(); // Gather additional details for Checklist Goal
            GoalList.Add(ChecklistGoal);
        }
    }

    // Method for entering goal details
    public virtual void GetValues()
    {
        Console.WriteLine("Enter goal name: ");
        GoalName = Console.ReadLine();
        Console.WriteLine("Enter goal description: ");
        GoalDescription = Console.ReadLine();
        Console.WriteLine("Enter point value: ");
        PointValue = int.Parse(Console.ReadLine());
    }
}
