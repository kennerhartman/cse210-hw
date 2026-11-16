using System;

class Program
{
    static List<Goal> _goals = new List<Goal>();

    static void Main(string[] args)
    {
        Goal g1 = new Goal("Read scriptures everyday", "Spend 30 minutes everyday reading the Book of Mormon");
        Goal g2 = new Goal("Give a talk", "Speak in sacrament meeting");

        Console.WriteLine(g1.GetGoalInformation());
        Console.WriteLine(g2.GetGoalInformation());
    }
}