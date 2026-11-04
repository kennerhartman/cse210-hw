class Menu
{
    private int _totalDurationOfActivities = 0;
    private int _totalNumberOfActivites = 0; 

    public bool DisplayMenu()
    {
        Console.WriteLine("Menu Options:");
        
        Console.WriteLine("    1. Start breathing activity");
        Console.WriteLine("    2. Start reflection activity");
        Console.WriteLine("    3. Start listing activity");
        Console.WriteLine("    4. Quit");

        Console.Write("Select a choice from the menu: ");
        
        string response = Console.ReadLine();

        if (int.TryParse(response, out int option))
        {
            return this.ProcessUserInput(option);
        } 
        else
        {
            Console.Clear();

            Console.WriteLine($"'{response}' is not a valid option!\n");
        }

        return false;
    }

    public bool ProcessUserInput(int response)
    {
        Console.Clear();

        if (response == 1)
        {
            this.RunBreathingActivity();
        } 
        else if (response == 2)
        {
            this.RunReflectingActivity();
        }
        else if (response == 3)
        {
            this.RunListingActivity();
        }
        else if (response == 4)
        {
            Console.Write("Are you sure you want to quit? (y/n): ");
            string answer = Console.ReadLine();

            if (answer == "n")
            {
                Console.Clear();
            } 
            else
            {
                return true;
            }
        } 
        else
        {
            Console.WriteLine("Could not find a valid action to take.");
        }

        return false;
    }

    public int GetTotalDuration()
    {
        return this._totalDurationOfActivities;
    }

    public void AddToTotalDuration(int value)
    {
        this._totalDurationOfActivities += value;
    }

    public int GetTotalNumberOfActivitesCompleted()
    {
        return this._totalNumberOfActivites;
    }

    public void IncrementTotalNumberOfActivitesCompleted()
    {
        ++this._totalNumberOfActivites;
    }

    private void RunBreathingActivity()
    {
        BreathingActivty breathingActivty = new BreathingActivty("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");

       this.RunActivity(breathingActivty);
    }

    private void RunReflectingActivity()
    {
        ReflectingActivity reflectingActivity = new ReflectingActivity(
            "Reflecting Activity", 
            "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life."
        );

        this.RunActivity(reflectingActivity);
    }

    private void RunListingActivity()
    {
        ListingActivity listingActivity = new ListingActivity(
            "Listing Activity", 
            "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area."
        );

        this.RunActivity(listingActivity);
    }

    private void RunActivity(Activity activity)
    {
        activity.DisplayStartingMessage();
        activity.GetDurationFromUser();
        activity.DisplaySpinnerMessage("Get ready...", 3);
        activity.RunActivity(this);
    }
}