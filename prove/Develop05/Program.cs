using System;

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();

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