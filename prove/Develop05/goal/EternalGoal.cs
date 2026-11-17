class EternalGoal : IncrementalableGoal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
    }

    public EternalGoal(string name, string description, int points, int timesCompeleted) : base(name, description, points, false, timesCompeleted)
    {
    }

    public int GetTimesCompleted()
    {
        return this._timesCompleted;
    }

    public override int GetPoints()
    {
        return this._metadata.GetPoints() * this._timesCompleted;
    }

    public override void MarkCompeleted()
    {
        // eternal goals are never completed!
    }

    public override string GetFileString()
    {
        char delimiter = '|';
        string originalString = base.GetFileString();

        return $"{originalString}{delimiter}{this._timesCompleted}";
    }

    public override Type GetGoalType()
    {
        return Type.ETERNAL;
    }
}