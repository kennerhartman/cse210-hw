abstract class Activity
{
    private string _title;
    private string _description;
    private int _duration = 0;

    public Activity(string title, string description)
    {
        this._title = title;
        this._description = description;
    }

    public abstract void RunActivity(Menu menu);

    public int GetDuration()
    {
        return this._duration;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {this._title}.\n");
        Console.WriteLine($"{this._description}\n");
    }

    public void FinishActivity(Menu menu, int duration)
    {
        Console.WriteLine("\nWell Done!\n");
        Console.WriteLine($"You have completed another {this._duration} seconds of the {this._title}.");
        
        menu.AddToTotalDuration(duration);
        menu.IncrementTotalNumberOfActivitesCompleted();
    }

    public void FinishActivity(Menu menu)
    {
        this.FinishActivity(menu, this._duration);
    }

    public void GetDurationFromUser()
    {
        Console.Write("How long would you like for your session (in seconds?) ");

        while (true)
        {
            string inputString = Console.ReadLine();
            int duration = int.Parse(inputString);

            if (duration > 0)
            {
                this._duration = duration;

                break;
            } 
            else
            {
                Console.Clear();
                Console.Write("Invalid input. How long would you like for your session (in seconds?) ");
            }
        }
    }

    public void DisplayCountdownMessage(string message, int seconds, bool shouldClearConsole = true)
    {
        Console.CursorVisible = false;

        if (shouldClearConsole)
        {
            Console.Clear();
        }

        Console.Write($"{message} ");

        for (int i = seconds; i > 0; i--)
        {
            if (i > 0)
            {
                Console.Write("\b \b");
            }
            
            Console.Write(i);

            Thread.Sleep(1000);
        }

        Console.CursorVisible = true;
        Console.WriteLine();
    }

    public void DisplaySpinnerMessage(string message, int seconds, bool shouldClearConsole = true)
    {
        char[] spinners = {'|', '/', '-', '\\', '|', '/', '-', '\\'};
        
        int i = 0;

        DateTime endTime = DateTime.Now.AddSeconds(seconds);

        if (shouldClearConsole)
        {
            Console.Clear();
        }

        Console.Write($"{message} ");

        while (DateTime.Now < endTime)
        {
            if (i > 0)
            {
                Console.Write("\b \b");
            }
            
            Console.Write(spinners[i % spinners.Length]);

            ++i;

            Thread.Sleep(200);
        }

        Console.Write("\b \b");
        Console.WriteLine();
    }
}