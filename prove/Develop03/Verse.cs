using System.Collections.Generic;
using System.Linq;

class Verse {
   private string _scriptureText;
   private List<ScriptureWord> _words;
   private string _scriptureReference;

   public Verse(){
       _scriptureText = "";
       _words = new List<ScriptureWord>();
       _scriptureReference = "";
   }

   public Verse(string text, string reference) {
       _scriptureText = text;
       _scriptureReference = reference;
       _words = new List<ScriptureWord>();

       // Split text into individual words and store in _words list
       string[] wordsArray = text.Split(' ');
       foreach (string word in wordsArray) {
           _words.Add(new ScriptureWord(word));
       }
   }

   public override string ToString() {
       List<string> displayedWords = new List<string>();
       foreach (ScriptureWord word in _words) {
           displayedWords.Add(word.Display());
       }
       return $"{_scriptureReference}: {string.Join(" ", displayedWords)}";
   }

   public bool AllWordsHidden() {
       return _words.All(word => word.IsHidden());
   }

   public void HideRandomWord() {
       // Placeholder for hiding a random word in the scripture
       var wordsToHide = _words.Where(word => !word.IsHidden()).ToList();
       if (wordsToHide.Any()) {
           Random rand = new Random();
           int index = rand.Next(wordsToHide.Count);
           wordsToHide[index].Hide();
       }
   }
}
