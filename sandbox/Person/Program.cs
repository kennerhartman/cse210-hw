class Program
{
    static void Main(string[] args)
    {
        Person normalPerson = new Person("Bob", "Floyd", 43, 175.3);
        // Console.WriteLine(normalPerson.GetPersonInformation());

        Police police = new Police("Lance", "Sterling", 34, 186, "Taser");
        // Console.WriteLine(police.GetPoliceInformation());

        Doctor doctor = new Doctor("John", "Smith", 49, 157, "Stethoscope");
        // Console.WriteLine(doctor.GetDoctorInformation());

        List<Person> people = new List<Person>();

        people.Add(normalPerson);
        people.Add(police);
        people.Add(doctor);

        foreach (Person person in people)
        {
            Console.WriteLine(person.GetPersonInformation());
        }
    }
}
