class Goal
{
    private string _name;
    private string _description;
    private bool _isCompleted = false;
    
    private GoalMetadata _metadata;

    public Goal(string name, string description, int points, int bonusPoints, int timesCompleted, bool isCompleted)
    {
        this._name = name;
        this._description = description;
        this._isCompleted = isCompleted;

        this._metadata = new GoalMetadata(points, bonusPoints, timesCompleted, 0);
    }

    public Goal(string name, string description, int points)
    {
        this._name = name;
        this._description = description;
        this._metadata = new GoalMetadata(points, 0, 0, 0);
    }

    public string GetGoalInformation()
    {
        return $"[ ] {this._name} ({this._description})"; // TODO: IMPLEMENT
    }

    public string GetFileString()
    {
        return ""; // TODO: IMPLEMENT
    }
}