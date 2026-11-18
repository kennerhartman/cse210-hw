using System;

class Program
{
    // For this program, I went above and beyond by allowing the user to edit the metadata of
    // the goals they have created.  This includes editing a goal's name, description, and points.
    //
    // If the goal is a checklist goal, the user can also edit the amount of bonus points awarded to them
    // for completing it and how many times they need to complete the goal to be awarded those bonus points.

    static void Main(string[] args)
    {
        Menu menu = new Menu();

        menu.DisplayWelcomeMessage();

        while (true)
        {
            bool exit = menu.DisplayMenu();

            if (exit)
            {
                break;
            }
        }
    }
}