abstract class Goal
{
    private string _name;
    private string _description;
    
    protected GoalMetadata _metadata;

    public Goal(string name, string description, int points, bool isCompleted)
    {
        this._name = name;
        this._description = description;

        this._metadata = new GoalMetadata(points, isCompleted);
    }

    public Goal(string name, string description, int points)
    {
        this._name = name;
        this._description = description;
        this._metadata = new GoalMetadata(points, false);
    }

    public virtual int GetPoints()
    {
        return this._metadata.GetIsCompeleted() ? this._metadata.GetPoints() : 0;
    }

    public virtual void MarkCompeleted()
    {
        this._metadata.MarkCompeleted();
    }

    public virtual string GetGoalInformation()
    {
        string compeltedString = this._metadata.GetIsCompeleted() ? "[x]" : "[ ]";

        return $"{compeltedString} {this._name} ({this._description})";
    }

    public virtual string GetFileString()
    {
        char delimiter = '|';

        return $"{this._name}{delimiter}{this.GetGoalType()}{delimiter}{this._description}{delimiter}{this._metadata.GetPoints()}{delimiter}{this._metadata.GetIsCompeleted()}";
    }

    public abstract Type GetGoalType();

    public enum Type {
        SIMPLE,
        ETERNAL,
        CHECKLIST
    }
}