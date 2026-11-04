using System;

class Program
{
    // This assignment exceeds requirements by:
    //     - Keeping track how many times the user has done an activity.
    //     - The total time they have spent doing the various activities. (This includes the total time they spent doing the breathing exercise 
    //         by counting how long the exercise went for, not how long they said they wanted to do it for.)
    //     - Added another activity that gives the user a prompt to think and journal about.

    static void Main(string[] args)
    {
        Console.Clear();

        Menu menu = new Menu();

        while (true)
        {
            bool shouldExit = menu.DisplayMenu();

            if (shouldExit)
            {
                break;
            }
        }

        Console.WriteLine($"You spent a total of {menu.GetTotalDuration()} seconds doing mindfullness across {menu.GetTotalNumberOfActivitesCompleted()} activities!");
    }
}