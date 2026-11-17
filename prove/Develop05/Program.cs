using System;

class Program
{
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