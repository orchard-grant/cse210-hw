class DisplayGoals : Base
{
    public void PrintGoalList()
{
    Console.WriteLine("Items in list:");
    foreach (var goal in GoalList)
    {
        Console.WriteLine($"Goal Name: {goal.GoalName}, Description: {goal.GoalDescription}, Point Value: {goal.PointValue}");
    }
}
}