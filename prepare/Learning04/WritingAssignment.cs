class WritingAssignement : Assignment 
{
    private string _title;

    public WritingAssignement(string studentName, string topic, string title) : base(studentName, topic)
    {
        this._title = title;
    }

    public string GetWritingInformation()
    {
        return $"{this._title} by {this._studentName}";
    }
}