using System;
using System.Collections.Generic;

// main program class, where everything is done, very important
public class Program
{
    // creating methods of journal and prompt generator
    private static Journal workingJournal = new Journal();
    private static Prompt promptGenerator = new Prompt();

    public static void Main(string[] args)
    {
        workingJournal.Initialize();
        MenuLoop();
    }

    public static void MenuLoop()
    {
        // variable created to make loop
        int exitVar = 0;

        while (exitVar == 0)
        {
            // menu options dislpayed to the user
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    WriteNewEntry(); // creates a new journal entry
                    break;
                case "2":
                    workingJournal.Display(); // shows the user the journal
                    break;
                case "3":
                    SaveJournalFile(); // saves the journal to file
                    break;
                case "4":
                    LoadJournalFile(); // loads the journal from file
                    break;
                case "5":
                    exitVar= 1; // changes the loop variable to 1 to end the loop
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again."); // in case they type something that is not a number
                    break;
            }
        }
    }

    public static void WriteNewEntry() // method to write new entry
    {
        string prompt = promptGenerator.GeneratePrompt(); // makes a new prompt for the entry
        Console.WriteLine(prompt); // displays to the user
        string response = Console.ReadLine(); // gets the users response
        string dateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"); // gets date time
        Entry newEntry = new Entry(prompt, dateTime, response); 
        workingJournal.AppendEntry(newEntry); // adds entry to the journal
    }

    public static void SaveJournalFile()
{
    Console.Write("Enter filename to save (e.g., journal.txt): "); // saves journal to text file
    string filename = Console.ReadLine();
    workingJournal.SaveToFile(filename);
}


    public static void LoadJournalFile()
{
    Console.Write("Enter filename to load (e.g., journal.txt): "); // gets user input for name to name journal
    string filename = Console.ReadLine();
    workingJournal.LoadFromFile(filename);
}

}
