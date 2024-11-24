using System;
using System.Collections.Generic;
using System.IO;

class GoalFileManager : Base
{
    // Method to save the current goals to a file
    public void SaveGoals()
    {
        Console.WriteLine("Please enter the name of the file: ");
        string fileName = Console.ReadLine(); // Get file name from the user
        
        try
        {
            // Open the file for writing
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                // Iterate through the list of goals and write each to the file
                foreach (var goal in GoalList)
                {
                    writer.WriteLine($"{goal.GoalName},{goal.GoalDescription},{goal.PointValue}");
                }
            }

            Console.WriteLine("Goals saved successfully.");
            GoalList.Clear(); // Clear the list after saving to prevent duplication
        }
        catch (Exception ex)
        {
            // Handle any errors that occur during the save process
            Console.WriteLine($"Error saving goals: {ex.Message}");
        }
    }

    // Method to load goals from a file
    public List<Base> LoadGoals()
    {
        Console.WriteLine("Please enter the name of the file you want to load: ");
        string fileName = Console.ReadLine(); // Get file name from the user
        List<Base> loadedGoals = new List<Base>(); // Temporary list to store loaded goals

        try
        {
            // Check if the file exists
            if (File.Exists(fileName))
            {
                // Open the file for reading
                using (StreamReader reader = new StreamReader(fileName))
                {
                    string line;
                    // Read each line in the file
                    while ((line = reader.ReadLine()) != null)
                    {
                        // Split the line into parts and create a new goal object
                        string[] parts = line.Split(',');
                        if (parts.Length == 3)
                        {
                            Base goal = new Base
                            {
                                GoalName = parts[0], // Assign goal name
                                GoalDescription = parts[1], // Assign goal description
                                PointValue = int.Parse(parts[2]) // Parse and assign point value
                            };
                            loadedGoals.Add(goal); // Add goal to the list
                        }
                    }
                }

                Console.WriteLine("Goals loaded successfully.");
            }
            else
            {
                Console.WriteLine("File not found. No goals loaded.");
            }
        }
        catch (Exception ex)
        {
            // Handle any errors that occur during the load process
            Console.WriteLine($"Error loading goals: {ex.Message}");
        }

        // Update the main goal list with the loaded goals
        GoalList = loadedGoals;

        return GoalList; // Return the list of loaded goals
    }
}
