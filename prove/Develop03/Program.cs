using System;
using System.Collections.Generic;
using System.Linq;

class Program {
   static void Main(string[] args) {
       Console.Clear();

       // Initialize ScriptureReference object to gather user input
       ScriptureReference scriptureReference = new ScriptureReference();
       string scriptureText = scriptureReference.GetTextInput();
       string scriptureRef = scriptureReference.GetReferenceInput();

       // Create a Verse object with the given scripture text and reference
       Verse verse = new Verse(scriptureText, scriptureRef);

       // Display and hide words in the scripture progressively
       while (!verse.AllWordsHidden()) {
           Console.Clear();
           Console.WriteLine(verse.ToString());
           Console.WriteLine("Press Enter to continue or type 'quit' to exit.");
           string userInput = Console.ReadLine();

           if (userInput == "quit") {
               break;
           }

           verse.HideRandomWord();
       }
   }
}
