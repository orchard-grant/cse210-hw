
using System;


class Program
{
    static void Main(string[] args)
    {
        MainMenu main = new MainMenu();
        string input = main.OptionsDisplay();

        while (input != "5")
        {
            if (input == "1")
            {
            FullActivity activity = main.PickActivity(input);

            activity.ActivitySetup();

            activity.StartActivity();

            activity.FinishActivity();

            input = main.OptionsDisplay();
            }

            else if (input == "2")
            {
            FullActivity activity = main.PickActivity(input);

            activity.ActivitySetup();

            activity.StartActivity();

            activity.FinishActivity();

            input = main.OptionsDisplay();
            }

            else if (input == "3")
            {
            FullActivity activity = main.PickActivity(input);

            activity.ActivitySetup();

            activity.StartActivity();

            activity.FinishActivity();

            input = main.OptionsDisplay();
            }

            else if (input == "4")
            {
                FullActivity activity = main.PickActivity(input);

                input = main.OptionsDisplay();
            }
        }
    }
}
