class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
    }

    public SimpleGoal(string name, string description, int points, bool isCompleted) : base(name, description, points, isCompleted)
    {
    }

    public override Type GetGoalType()
    {
        return Type.SIMPLE;
    }
}