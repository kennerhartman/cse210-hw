class ChecklistGoal : Goal
{
    private int _bonusPoints;
    private int _timesToCompelete;

    public ChecklistGoal(string name, string description, int points, int bonusPoints, int timesToComplete) : base(name, description, points)
    {
        this._bonusPoints = bonusPoints;
        this._timesToCompelete = timesToComplete;
    }

    public override string GetGoalInformation()
    {
        string originalString = base.GetGoalInformation();
        
        return $"{originalString} -- Currently Completed: {this._metadata.GetTimesCompeleted()}/{this._timesToCompelete}";
    }
}