class GoalMetadata
{
    private int _points;
    private bool _isCompleted = false;

    public GoalMetadata(int points, bool isCompleted)
    {
        this._points = points;
        this._isCompleted = isCompleted;
    }

    public int GetPoints()
    {
        return this._points;
    }

    public void SetPoints(int value)
    {
        if (value > 0)
        {
            this._points = value;
        }
    }

    public bool GetIsCompeleted()
    {
        return this._isCompleted;
    }

    public void MarkCompeleted()
    {
        this._isCompleted = true;
    }

    public void Update(Goal goal)
    {
        if (goal is ChecklistGoal checklistGoal)
        {
            this._isCompleted =  checklistGoal.GetTimesCompeleted() >= checklistGoal.GetTimesToCompelete();
        }
    }
}