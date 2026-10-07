using System;

class Program
{
    // Some things that I did to exceed requirements for this assignment were adding checks to ensure the user added the ".txt" extension to their filename when saving/loading a file.  
    // Another thing I did was preventing the user from accidentally overwriting a file they already saved their journal entries to by displaying a dialog that 
    // asks them for confirmation to overwrite the file.  I also added checks in both the load and save file methods to ensure that the file the user specified 
    // actually exists before loading/saving the data to ensure the program does not crash if the file does not exist.

    static void Main(string[] args)
    {
        Menu menu = new Menu();

        bool running = true;

        Console.WriteLine("Welcome to the journal program!");
        Console.WriteLine("Please select one of the following choices:");

        while (running)
        {
            bool shouldQuit = menu.DisplayMenu();

            if (shouldQuit)
            {
                running = false;
            }
        }
    }
}