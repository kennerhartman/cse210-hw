class Doctor : Person
{
    private string _tools;

    public Doctor(string firstName, string lastName, int age, double weight, string tools) : base(firstName, lastName, age, weight)
    {
        this._tools = tools;
    }

    public string GetDoctorInformation()
    {
        return $"Tools: {this._tools}. {this.GetPersonInformation()}";
    }
}