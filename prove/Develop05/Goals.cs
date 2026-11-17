class Goals
{
    private List<Goal> _goals = new List<Goal>();

    public int GetTotalPoints()
    {
        int points = 0;

        foreach (Goal goal in this._goals)
        {
            points += goal.GetPoints();

            if (goal is ChecklistGoal checklistGoal)
            {
                points += checklistGoal.GetBonusPoints();
            }
        }

        return points;
    }

    public void CreateGoal()
    {
        Console.WriteLine("The types of goals are:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
        
        Console.Write("Which type of goal would you like to create? ");
        string goalTypeString = Console.ReadLine();
        int parsedGoalType = int.Parse(goalTypeString);

        Console.Write("\nWhat is the name of your goal? ");
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

        Console.Clear();
    }

    public void ListGoals()
    {
        if (this._goals.Count() == 0)
        {
            Console.WriteLine("You have no goals to dispaly.\n");
        } 
        else
        {
            Console.WriteLine("Your goals are:");

            int counter = 1;

            foreach (Goal goal in this._goals)
            {
                Console.WriteLine($"  {counter}. {goal.GetGoalInformation()}");

                ++counter;
            }

            Console.WriteLine();
        }
    }

    public void SaveGoals()
    {
        Console.Write("Please enter the filename: ");
        string filename = Console.ReadLine();

        if (!filename.EndsWith(".txt"))
        {
            filename += ".txt";
        }

        List<string> lines = [];

        foreach (Goal goal in this._goals)
        {
            lines.Add(goal.GetFileString());
        }

        if (File.Exists(filename))
        {
            Console.Write("This file already exists. Do you want to overwrite it? (y/n)");
            string response = Console.ReadLine();

            if (response == "y")
            {
                File.WriteAllLines(filename, lines);
            }
        } 
        else
        {
            File.WriteAllLines(filename, lines);
        }
    }

    public void LoadGoals()
    {
        Console.Write("Please enter the filename to load: ");
        string filename = Console.ReadLine();

        if (!filename.EndsWith(".txt"))
        {
            filename += ".txt";
        }

        if (!File.Exists(filename))
        {
            Console.WriteLine($"Could not find file with name {filename}.\n");
            
            return;
        }

        this._goals.Clear();

        List<string> lines = File.ReadAllLines(filename).ToList();

        foreach (string line in lines)
        {
            string[] parts = line.Split('|');

            string goalName = parts[0];
            string goalTypeString = parts[1];
            string goalDescription = parts[2];
            
            int points = int.Parse(parts[3]);

            bool isCompeleted = bool.Parse(parts[4]);

            Goal.Type goalType = Enum.Parse<Goal.Type>(goalTypeString);

            Goal goal = null;

            switch (goalType)
            {
                case Goal.Type.SIMPLE:
                    goal = new SimpleGoal(
                        goalName,
                        goalDescription,
                        points,
                        isCompeleted
                    );

                    break;
                case Goal.Type.ETERNAL:
                    goal = new EternalGoal(
                        goalName,
                        goalDescription,
                        points,
                        int.Parse(parts[5])
                    );

                    break;
                case Goal.Type.CHECKLIST:
                    int bonusPoints = int.Parse(parts[5]);
                    int timesToComplete = int.Parse(parts[6]);
                    int timesCompleted = int.Parse(parts[7]);

                    goal = new ChecklistGoal(
                        goalName,
                        goalDescription,
                        points,
                        isCompeleted,
                        bonusPoints,
                        timesToComplete,
                        timesCompleted
                    );

                    break;
            }

            if (goal != null)
            {
                this._goals.Add(goal);
            }
        }
    }

    public void RecordEvent()
    {
        Console.Clear();

        this.ListGoals();

        Console.Write("Select a goal to mark as completed: ");

        string goalIndexString = Console.ReadLine();
        int goalIndexAdjusted = int.Parse(goalIndexString) - 1;

        if (goalIndexAdjusted < 0 || goalIndexAdjusted >= this._goals.Count())
        {
            Console.WriteLine("Invalid index.\n");

            return;
        }

        Goal goal = this._goals[goalIndexAdjusted];

        if (goal is IncrementalableGoal checklistGoal)
        {
            checklistGoal.IncrementTimesCompleted();
        } 
        else
        {
            goal.MarkCompeleted();
        }
    }
}