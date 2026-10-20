using System;

class Program
{
    static void Main(string[] args)
    {
        Menu _menu = new Menu();

        while (_menu.IsRunning())
        {
            _menu.DisplayMenu();
        }
    }
}