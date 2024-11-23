using System;

class Program
{
    static void Main(string[] args)
    {
        int userInput;

        do
        {
            Console.WriteLine("Welcome to the Goal game.");
            Console.WriteLine("-------------------------");
            Console.WriteLine("1. Create new goals");
            Console.WriteLine("2. List current goals");
            Console.WriteLine("3. Save current goals");
            Console.WriteLine("4. Load goal");
            Console.WriteLine("5. Record event");
            Console.WriteLine("6. To exit program");
            Console.WriteLine("Enter a number: ");
            Console.WriteLine("-------------------------");
            userInput = int.Parse(Console.ReadLine());

            if (userInput == 1)
            {
                Console.WriteLine("Create a new goals");
                Base b1 = new Base();
                b1.goalMenu();
            }
            else if (userInput == 2)
            {
                DisplayGoals d1 = new DisplayGoals();
                d1.PrintGoalList();
            }
            else if (userInput == 3)
            {
                GoalFileManager c1 = new GoalFileManager();
                c1.SaveGoals();
            }
            else if (userInput == 4)
            {
                GoalFileManager c1 = new GoalFileManager();
                c1.LoadGoals();
            }
            else if (userInput == 5)
            {
                UpdateGoals u1 = new UpdateGoals();
                u1.AddPoints();
            }
            else if (userInput == 6)
            {
                Console.WriteLine("Good luck on your goals!");
            }
            else
            {
                Console.WriteLine("Invalid input, please try again.");
            }

        } while (userInput != 6);
    }
}