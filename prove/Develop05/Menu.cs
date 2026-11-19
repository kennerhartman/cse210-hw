class Menu
{
    private Goals _goals = new Goals();

    public bool DisplayMenu()
    {
        Console.WriteLine($"You have {this._goals.GetTotalPoints()} point(s).\n");
        
        Console.WriteLine("Menu Options:");
        
        Console.WriteLine("1. Create new goal");
        Console.WriteLine("2. Edit Goal");
        Console.WriteLine("3. List goals");
        Console.WriteLine("4. Save goals");
        Console.WriteLine("5. Load goals");
        Console.WriteLine("6. Record Event");
        Console.WriteLine("7. Quit");

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
                this.EditGoal();

                return false;
            case 3:
                this._goals.ListGoals();

                return false;
            case 4:
                this._goals.SaveGoals();

                return false;
            case 5:
                this._goals.LoadGoals();
                
                return false;
            case 6:
                this._goals.RecordEvent();

                return false;
            case 7:
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

    private void EditGoal()
    {
        Goal goal = this._goals.SelectGoal("Select a goal to edit: ");

        if (goal == null)
        {
            return;
        }

        int position = 0;

        List<(string label, Action execute)> options = new List<(string label, Action execute)>()
        {
            ("Edit goal name", () => EditGoalName(goal)),
            ("Edit goal description", () => EditGoalDescription(goal)),
            ("Edit goal points", () => EditGoalPoints(goal))
        };

        if (goal is ChecklistGoal)
        {
            options.Add(
                ("Edit goal bonus points", () => EditGoalBonusPoints(goal))
            );

            options.Add(
                ("Edit times to complete", () => EditGoalTimesToComplete(goal))
            );
        }

        while (true)
        {
            Console.Clear();

            for (int i = 0; i < options.Count; ++i)
            {
                Console.Write(i == position ? "[x] " : "[ ] ");
                Console.WriteLine(options[i].label);
            }

            ConsoleKeyInfo key = Console.ReadKey(intercept: true);

            switch (key.Key)
            {
                case ConsoleKey.UpArrow when position > 0:
                    --position;
                    break;

                case ConsoleKey.DownArrow when position < options.Count - 1:
                    ++position;
                    break;

                case ConsoleKey.Enter:
                    options[position].execute();

                    goal.UpdateStatus();

                    return;

                case ConsoleKey.Escape:
                    return;
            }

            Console.Clear();
        }
    }

    private void EditGoalName(Goal goal)
    {
        Console.Write("New Name: ");
        string name = Console.ReadLine();

        goal.SetName(name);
    }

    private void EditGoalDescription(Goal goal)
    {
        Console.Write("New Description: ");
        string description = Console.ReadLine();

        goal.SetDescription(description);
    }

    private void EditGoalPoints(Goal goal)
    {
        Console.Write("New Amount of Points: ");
        int points = int.Parse(Console.ReadLine());

        goal.SetPoints(points);
    }

    private void EditGoalBonusPoints(Goal goal)
    {
        if (goal is ChecklistGoal checklistGoal)
        {
            Console.Write("New Amount of Bonus Points: ");
            int bonusPoints = int.Parse(Console.ReadLine());

            checklistGoal.SetBonusPoints(bonusPoints);
        }
    }

    private void EditGoalTimesToComplete(Goal goal)
    {
        if (goal is ChecklistGoal checklistGoal)
        {
            Console.Write("New Number of Times to Complete: ");
            int timesToComplete = int.Parse(Console.ReadLine());

            checklistGoal.SetTimesToComplete(timesToComplete);
        }
    }
}