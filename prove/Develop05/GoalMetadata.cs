class GoalMetadata
{
    private int _points;
    private int _timesCompleted = 0;
    private bool _isCompleted = false;

    public GoalMetadata(int points, int timesCompleted, bool isCompleted)
    {
        this._points = points;
        this._timesCompleted = timesCompleted;
    }

    public void SetPoints(int value)
    {
        if (value > 0)
        {
            this._points = value;
        }
    }

    public int GetTimesCompeleted()
    {
        return this._timesCompleted;
    }

    public void IncrementTimesCompleted()
    {
        ++this._timesCompleted;
    }
}