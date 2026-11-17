class Menu
{
    private Goals _goals = new Goals();

    public bool DisplayMenu()
    {
        Console.WriteLine($"You have {this._goals.GetTotalPoints()} point(s).\n");
        
        Console.WriteLine("Menu Options:");
        
        Console.WriteLine("1. Create new goal");
        Console.WriteLine("2. List goals");
        Console.WriteLine("3. Save goals");
        Console.WriteLine("4. Load goals");
        Console.WriteLine("5. Record Event");
        Console.WriteLine("6. Quit");

        Console.Write("\nSelect a choice from the menu: ");
        
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

        switch (response)
        {
            case 1:
                this._goals.CreateGoal();

                return false;
            case 2:
                this._goals.ListGoals();

                return false;
            case 3:
                this._goals.SaveGoals();

                return false;
            case 4:
                this._goals.LoadGoals();
                
                return false;
            case 5:
                this._goals.RecordEvent();

                return false;
            case 6:
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

                break;
        }

        return false;
    }

    public void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to Eternal Quest!\n");
    }
}