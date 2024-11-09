using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
public class MainMenu
{
    // Creates a count for the various activities.
    int BreathingActivityCount = 0;
    int ReflectingActivityCount = 0;
    int ListingActivityCount = 0;

    // Display menu to the users.
    public string OptionsDisplay()
    {
        string input = "";
        do
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("    1. Start Breathing Activity");
            Console.WriteLine("    2. Start Reflecting Activity");
            Console.WriteLine("    3. Start Listing Activity");
            Console.WriteLine("    4. Count The Number Of Activitys Completed");
            Console.WriteLine("    5. Quit");
            Console.Write("Select a choice from the menu: ");
            input = Console.ReadLine();
            Console.Clear();
        } while (input != "1" && input != "2" && input != "3" && input != "4" && input != "5");

        return input;
    }

    // Sets up and call the various activities.
    public FullActivity PickActivity(string input)
    {
        FullActivity activity = new FullActivity();

        if (input == "1")
        {
            activity = new BreathingActivity();
            BreathingActivityCount += 1;
        }
        else if (input == "2")
        {
            activity = new ReflectingActivity();
            ReflectingActivityCount +=1;
        }

        else if (input == "3")
        {
            activity = new ListingActivity();
            ListingActivityCount +=1;
        }

        else if (input == "4")
        {
            Console.WriteLine("These are number of activitys completed: ");
            Console.WriteLine();
            Console.WriteLine($"Breathing Activity: {BreathingActivityCount}");
            Console.WriteLine($"Reflecting Activity: {ReflectingActivityCount}");
            Console.WriteLine($"Listing Activity: {ListingActivityCount}");
            Console.WriteLine();
        }
        return activity;
    }

    


}