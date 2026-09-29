public class Job
{
    public String _jobTitle;
    public String _company;
    public DateOnly _startYear;
    public DateOnly _endYear;

    public void Display()
    {
        Console.WriteLine($"{this._jobTitle} ({this._company}) {this._startYear.Year}-{this._endYear.Year}");
    }
}