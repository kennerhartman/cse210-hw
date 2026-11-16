class Menu
{
    private List<Goal> _goals = new List<Goal>();

    public bool DisplayMenu()
    {
        Console.WriteLine("Menu Options:");
        
        Console.WriteLine("1. Create new goal");
        Console.WriteLine("2. List goals");
        Console.WriteLine("3. Save goals");
        Console.WriteLine("4. Load goals");
        Console.WriteLine("5. Record Event");
        Console.WriteLine("6. Quit");

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

        switch (response)
        {
            case 1:
                // TODO: IMPLEMENT "CREATE GOAL"
                this.CreateGoal();

                return false;
            case 2:
                this.ListGoals();

                return false;
            case 3:
                // TODO: IMPLEMENT "SAVE GOALS"
                return false;
            case 4:
                // TODO: IMPLEMENT "LOAD GOALS"
                return false;
            case 5:
                // TODO: IMPLEMENT "RECORD EVENT"
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

    private void CreateGoal()
    {
        Console.WriteLine("The types of goals are:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
        
        Console.Write("Which type of goal would you like to create? ");
        string goalTypeString = Console.ReadLine();
        int parsedGoalType = int.Parse(goalTypeString);

        Console.Write("What is the name of your goal? ");
        string goalName = Console.ReadLine();

        Console.Write("What is a short description of it? ");
        string goalDescription = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        string goalPointsString = Console.ReadLine();
        int parsedGoalPoints = int.Parse(goalPointsString);

        Goal goal = null;

        switch (parsedGoalType)
        {
            case 1:
                goal = new SimpleGoal(goalName, goalDescription, parsedGoalPoints);
                
                break;
            case 2:
                goal = new EternalGoal(goalName, goalDescription, parsedGoalPoints);
                
                break;
            case 3:
                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                string timesToCompleteGoalString = Console.ReadLine();
                int parsedTimesToCompleteGoal = int.Parse(timesToCompleteGoalString);
                
                Console.Write("What is the bonus for accomplishing it that many times? ");
                string bonusPointsString = Console.ReadLine();
                int parsedBonusPoints = int.Parse(bonusPointsString);
                
                goal = new ChecklistGoal(goalName, goalDescription, parsedGoalPoints, parsedBonusPoints, parsedTimesToCompleteGoal);

                break;
        }


        if (goal != null)
        {
            this._goals.Add(goal);
        }
    }

    private void ListGoals()
    {
        Console.WriteLine("Your goals are:");

        int counter = 1;
        
        foreach (Goal goal in this._goals)
        {
            Console.WriteLine($"  {counter}. {goal.GetGoalInformation()}");

            ++counter;
        }
    }
}