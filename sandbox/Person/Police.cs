class Police : Person
{
    private string _weapons;

    public Police(string firstName, string lastName, int age, double weight, string weapons) : base(firstName, lastName, age, weight)
    {
        this._weapons = weapons;
    }

    public string GetPoliceInformation()
    {
        return $"Weapons: {this._weapons}. {this.GetPersonInformation()}";
    }
}