abstract class Person
{
    private string _firstName;
    private string _lastName;
    private int _age;
    private double _weight;

    public Person(string firstName, string lastName, int age, double weight)
    {
        this._firstName = firstName;
        this._lastName = lastName;
        this._age = age;
        this._weight = weight;
    }

    public virtual string GetPersonInformation()
    {
        return $"{this._firstName} {this._lastName} is {this._age} {(this._age == 1 ? "year" : "years")} old and weighs {this._weight} lbs. Salary: ${this.GetSalary()}.";
    }

    public abstract double GetSalary();
}