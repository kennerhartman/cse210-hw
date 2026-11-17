class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
    }

    public EternalGoal(string name, string description, int points, int timesCompleted, bool isCompleted) : base(name, description, points, timesCompleted, isCompleted)
    {
    }

    public override Type GetGoalType()
    {
        return Type.ETERNAL;
    }
}