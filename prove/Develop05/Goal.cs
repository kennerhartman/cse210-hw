abstract class Goal
{
    private string _name;
    private string _description;
    
    protected GoalMetadata _metadata;

    public Goal(string name, string description, int points, int timesCompleted, bool isCompleted)
    {
        this._name = name;
        this._description = description;

        this._metadata = new GoalMetadata(points, timesCompleted, isCompleted);
    }

    public Goal(string name, string description, int points)
    {
        this._name = name;
        this._description = description;
        this._metadata = new GoalMetadata(points, 0, false);
    }

    public virtual string GetGoalInformation()
    {
        return $"[ ] {this._name} ({this._description})";
    }

    public virtual string GetFileString()
    {
        return "";
    }
}