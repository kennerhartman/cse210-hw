class Activity
{
    private string _title;
    private string _description;
    private int _duration = 0;

    public Activity(string title, string description)
    {
        this._title = title;
        this._description = description;
    }

    public int GetDuration()
    {
        return this._duration;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {this._title}.\n");
        Console.WriteLine($"{this._description}\n");
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("\nWell Done!\n");
        Console.WriteLine($"You have completed another {this._duration} seconds of the {this._title}.");
    }

    public void GetDurationFromUser()
    {
        Console.Write("How long would you like for your session (in seconds?) ");

        string inputString = Console.ReadLine();
        int duration = int.Parse(inputString);

        if (duration > 0)
        {
            // TODO: GET INPUT AGAIN IF <= 0

            this._duration = duration;
        }
    }

    public void DisplayCountdownMessage(string message, int seconds)
    {
        Console.CursorVisible = false;

        for (int i = seconds; i > 0; i--)
        {
            Console.Clear(); // TODO: POLISH
            Console.WriteLine($"{message} {i}");
            Thread.Sleep(1000);
        }

        Console.CursorVisible = true;
    }

    public void DisplaySpinnerMessage(string message, int seconds)
    {
        char[] spinners = {'|', '/', '-', '\\', '|', '/', '-', '\\'};
        
        int i = 0;

        DateTime endTime = DateTime.Now.AddSeconds(seconds);

        while (DateTime.Now < endTime)
        {
            Console.Clear(); // TODO: POLISH
            Console.WriteLine($"{message} {spinners[i % spinners.Length]}");

            ++i;

            Thread.Sleep(200);
        }
    }
}