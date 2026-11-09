class Police : Person
{
    private string _weapons;

    public Police(string firstName, string lastName, int age, double weight, string weapons) : base(firstName, lastName, age, weight)
    {
        this._weapons = weapons;
    }

    public override string GetPersonInformation()
    {
        return $"Weapons: {this._weapons}. {base.GetPersonInformation()}";
    }

    public override double GetSalary()
    {
        return 250000;
    }
}