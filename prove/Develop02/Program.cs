using System;

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();

        bool running = true;

        Console.WriteLine("Welcome to the journal program!");
        Console.WriteLine("Please select one of the following choices");

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