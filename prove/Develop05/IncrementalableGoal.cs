abstract class IncrementalableGoal : Goal
{
    protected int _timesCompleted;

    public IncrementalableGoal(string name, string description, int points, bool isCompleted, int timesCompeleted) : base(name, description, points, isCompleted)
    {
        this._timesCompleted = timesCompeleted;
    }

    public IncrementalableGoal(string name, string description, int points) : base(name, description, points)
    {
    }

    public int GetTimesCompeleted()
    {
        return this._timesCompleted;
    }

    public virtual void IncrementTimesCompleted()
    {
        ++this._timesCompleted;
    }
}