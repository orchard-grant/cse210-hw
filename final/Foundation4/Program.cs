using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a list to store different types of exercises
        List<Exercise> exerciseList = new List<Exercise>();
        
        // Add a running exercise to the list
        Running running = new Running("December 14, 2024", 25, 5.5);
        exerciseList.Add(running);

        // Add a stationary bicycle exercise to the list
        StationaryBicycles stationaryBicycles = new StationaryBicycles("December 14, 2024", 45, 12);
        exerciseList.Add(stationaryBicycles);

        // Add a swimming exercise to the list
        Swimming swimming = new Swimming("December 14, 2024", 30, 18);
        exerciseList.Add(swimming);

        // Display all exercises
        Console.WriteLine("Exercises:");
        Console.WriteLine();

        // Loop through the list and print the summary for each exercise
        foreach (Exercise exercise in exerciseList) 
        {
            Console.WriteLine(exercise.GetSummary());
        }
    }
}
