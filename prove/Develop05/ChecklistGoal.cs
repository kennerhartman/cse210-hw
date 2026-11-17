class ChecklistGoal : Goal
{
    private int _bonusPoints;
    private int _timesToCompelete;

    public ChecklistGoal(string name, string description, int points, int bonusPoints, int timesToComplete) : base(name, description, points)
    {
        this._bonusPoints = bonusPoints;
        this._timesToCompelete = timesToComplete;
    }

    public ChecklistGoal(string name, string description, int points, int timesCompleted, bool isCompeleted, int bonusPoints, int timesToComplete) : base(name, description, points, timesCompleted, isCompeleted)
    {
        this._bonusPoints = bonusPoints;
        this._timesToCompelete = timesToComplete;
    }

    public override string GetGoalInformation()
    {
        string originalString = base.GetGoalInformation();
        
        return $"{originalString} -- Currently Completed: {this._metadata.GetTimesCompeleted()}/{this._timesToCompelete}";
    }

    public override string GetFileString()
    {
        string originalString = base.GetFileString();
        char delimiter = '|';

        return $"{originalString}{delimiter}{this._bonusPoints}{delimiter}{this._timesToCompelete}";
    }

    public override Type GetGoalType()
    {
        return Type.CHECKLIST;
    }
}