class ChecklistGoal : IncrementalableGoal
{
    private int _bonusPoints;
    private int _timesToCompelete;

    public ChecklistGoal(string name, string description, int points, int bonusPoints, int timesToComplete) : base(name, description, points)
    {
        this._bonusPoints = bonusPoints;
        this._timesToCompelete = timesToComplete;
    }

    public ChecklistGoal(string name, string description, int points, bool isCompeleted, int bonusPoints, int timesToComplete, int timesCompleted) : base(name, description, points, isCompeleted, timesCompleted)
    {
        this._bonusPoints = bonusPoints;
        this._timesToCompelete = timesToComplete;
    }

    public override void IncrementTimesCompleted()
    {
        base.IncrementTimesCompleted();

        if (this._timesCompleted == this._timesToCompelete)
        {
            this.MarkCompeleted();
        }
    }

    public int GetBonusPoints()
    {
        return this._metadata.GetIsCompeleted() ? this._bonusPoints : 0;
    }

    public override string GetGoalInformation()
    {
        string originalString = base.GetGoalInformation();
        
        return $"{originalString} -- Currently Completed: {this.GetTimesCompeleted()}/{this._timesToCompelete}";
    }

    public override string GetFileString()
    {
        string originalString = base.GetFileString();
        char delimiter = '|';

        return $"{originalString}{delimiter}{this._bonusPoints}{delimiter}{this._timesToCompelete}{delimiter}{this._timesCompleted}";
    }

    public override Type GetGoalType()
    {
        return Type.CHECKLIST;
    }
}