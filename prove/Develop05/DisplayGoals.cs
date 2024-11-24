class DisplayGoals : Base
{
    // Method
    public void PrintGoalList()
    {
        Console.WriteLine("Items in list:");

        // Iterate through each goal
        foreach (var goal in GoalList)
        {
            // Display the details
            Console.WriteLine($"Goal Name: {goal.GoalName}, Description: {goal.GoalDescription}, Point Value: {goal.PointValue}");
        }
    }
}
