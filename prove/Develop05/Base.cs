using System;
using System.Collections.Generic;

class Base
{
    public string GoalName { get; set; }
    public string GoalDescription { get; set; }
    public int PointValue { get; set; }
    public int PointTotal { get; set; }
    public static List<Base> GoalList = new List<Base>();

    public Base()
    {

    }
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
            GoalList.Add(simpleGoal);
        }

        else if (userInput == 2)
        {
            EternalGoal EternalGoal = new EternalGoal();
            EternalGoal.GetValues();
            GoalList.Add(EternalGoal);
        }

        else if (userInput == 3)
        {
            ChecklistGoal ChecklistGoal = new ChecklistGoal();
            ChecklistGoal.GetValues();
            ChecklistGoal.GetBonusPoints();
            GoalList.Add(ChecklistGoal);
        }
    }

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