using System;

class ScriptureReference {
   private string _scriptureReference;
   private string _scriptureText;

   public string GetTextInput(){
         Console.WriteLine("**************************************************************");
         Console.WriteLine("********* Welcome to the scripture memorization program *******");
         Console.WriteLine("*  To start, please enter the scripture you want to memorize *");
         Console.WriteLine("**  After that, please enter the reference of the scripture **");
         Console.WriteLine("**************************************************************");
         Console.WriteLine("");
         Console.Write("Enter the text of the scripture: ");
         _scriptureText = Console.ReadLine();
         return _scriptureText;
  }

  public string GetReferenceInput(){
       Console.Write("Write the reference of the scripture: ");
       _scriptureReference = Console.ReadLine();
       return _scriptureReference;
  }
}

