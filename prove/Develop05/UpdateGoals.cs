using System.Drawing;

class UpdateGoals : Base
{
    public string userInput;
    private string ThirdItem;
    public void AddPoints()
    {
        Console.WriteLine("Which goal did you complete?");
        userInput = Console.ReadLine();

        if (userInput == GoalList[0].GoalName)
        {
            PointTotal = PointTotal + GoalList[0].PointValue;
        }

        Console.WriteLine("Your total score is: ");
        Console.WriteLine(PointTotal);
    }
}