using System;

class ScriptureWord {
   private string _wordText;
   private bool _isHidden;

   public ScriptureWord(string text) {
       _wordText = text;
       _isHidden = false;
   }

   public void Hide() {
       _isHidden = true;
   }

   public bool IsHidden(){
       return _isHidden;
   }

   public string Display() {
       if (_isHidden) {
           return "_______";
       }
       return _wordText;
   }
}
