class Doctor : Person
{
    private string _tools;

    public Doctor(string firstName, string lastName, int age, double weight, string tools) : base(firstName, lastName, age, weight)
    {
        this._tools = tools;
    }

    public override string GetPersonInformation()
    {
        return $"Tools: {this._tools}. {base.GetPersonInformation()}";
    }

    public override double GetSalary()
    {
        return 350000;
    }
}