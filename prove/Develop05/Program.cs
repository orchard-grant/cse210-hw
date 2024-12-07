using System;

class Program
{
    static void Main(string[] args)
    {
        int userInput;

        // Main program loop
        do
        {
            // Display the main menu
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

            // Read and parse the user's menu choice
            userInput = int.Parse(Console.ReadLine());

            // Handle menu option 1: Create new goals
            if (userInput == 1)
            {
                Console.WriteLine("Create new goals");
                Base b1 = new Base();
                b1.goalMenu(); // Call method to create goals
            }
            // Handle menu option 2: List current goals
            else if (userInput == 2)
            {
                DisplayGoals d1 = new DisplayGoals();
                d1.PrintGoalList(); // Call method to display goals
            }
            // Handle menu option 3: Save current goals
            else if (userInput == 3)
            {
                GoalFileManager c1 = new GoalFileManager();
                c1.SaveGoals(); // Call method to save goals to file
            }
            // Handle menu option 4: Load goals from file
            else if (userInput == 4)
            {
                GoalFileManager c1 = new GoalFileManager();
                c1.LoadGoals(); // Call method to load goals from file
            }
            // Handle menu option 5: Record an event (e.g., updating goals)
            else if (userInput == 5)
            {
                UpdateGoals u1 = new UpdateGoals();
                u1.AddPoints(); // Call method to update goal progress
            }
            // Handle menu option 6: Exit the program
            else if (userInput == 6)
            {
                Console.WriteLine("Good luck on your goals!");
            }
            // Handle invalid input
            else
            {
                Console.WriteLine("Invalid input, please try again.");
            }

        } while (userInput != 6); // Repeat until the user chooses to exit
    }
}
