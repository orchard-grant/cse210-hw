using System;
using System.Collections.Generic;
using System.IO;

class GoalFileManager : Base
{
    public void SaveGoals()
    {
        Console.WriteLine("Please enter the name of the file: ");
        string fileName = Console.ReadLine();
        try
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                foreach (var goal in GoalList)
                {
                    writer.WriteLine($"{goal.GoalName},{goal.GoalDescription},{goal.PointValue}");
                }
            }

            Console.WriteLine("Goals saved successfully.");
            GoalList.Clear();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving goals: {ex.Message}");
        }
    }

    public List<Base> LoadGoals()
    {
        Console.WriteLine("Please enter the name of the file you want to load: ");
        string fileName = Console.ReadLine();
        List<Base> loadedGoals = new List<Base>();

        try
        {
            if (File.Exists(fileName))
            {
                using (StreamReader reader = new StreamReader(fileName))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        if (parts.Length == 3)
                        {
                            Base goal = new Base
                            {
                                GoalName = parts[0],
                                GoalDescription = parts[1],
                                PointValue = int.Parse(parts[2])
                            };
                            loadedGoals.Add(goal);
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
            Console.WriteLine($"Error loading goals: {ex.Message}");
        }

        GoalList = loadedGoals;

        return GoalList;
    }
}