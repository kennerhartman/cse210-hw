class GoalMetadata
{
    private int _points;
    private int _bonusPoints = 0;

    private int _timesToComplete;
    private int _timesCompleted = 0;

    public GoalMetadata(int points, int timesToComplete)
    {
        this._points = points;
        this._timesToComplete = timesToComplete;
    }
    
    public GoalMetadata(int points, int bonusPoints, int timesCompleted, int timesToComplete)
    {
        this._points = points;
        this._bonusPoints = bonusPoints;
        this._timesCompleted = timesCompleted;
        this._timesToComplete = timesToComplete;
    }

    public void SetPoints(int value)
    {
        if (value > 0)
        {
            this._points = value;
        }
    }

    public void SetBonusPoints(int value)
    {
        if (value > 0)
        {
            this._bonusPoints = value;
        }
    }

    public void IncrementTimesCompleted()
    {
        ++this._timesCompleted;
    }
}