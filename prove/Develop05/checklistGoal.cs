using System;

class ChecklistGoal : Base
{ 
  public string GoalCount;
  public string BonusPoints;
    public ChecklistGoal()
    {

    }

    public override void GetValues()
    {
        base.GetValues();
    }

    public void GetBonusPoints()
    {
      Console.WriteLine("How many times do you want to complete this goal before recieving bonus points? ");
      GoalCount = Console.ReadLine();
      Console.WriteLine("How many bonus points do you want for completing the goals: ");
      BonusPoints = Console.ReadLine();
    }
}