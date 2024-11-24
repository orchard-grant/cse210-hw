using System.Drawing;

class UpdateGoals : Base
{
    public string userInput; // Stores user input for the goal they completed
    private string ThirdItem;

    // Method to add points
    public void AddPoints()
    {
        // Prompt the user to specify goal
        Console.WriteLine("Which goal did you complete?");
        userInput = Console.ReadLine(); // Read the user's input

        // Check if the input matches the first goal's name in the goal list
        if (userInput == GoalList[0].GoalName)
        {
            // Add the point value
            PointTotal = PointTotal + GoalList[0].PointValue;
        }

        // Display the updated total score to the user
        Console.WriteLine("Your total score is: ");
        Console.WriteLine(PointTotal);
    }
}
