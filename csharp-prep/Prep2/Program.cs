using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What percentage is your grade? ");

        string gradeString = Console.ReadLine();
        int grade = int.Parse(gradeString);

        char letter;

        if (grade >= 90)
        {
            letter = 'A';
        }
        else if (grade >= 80)
        {
            letter = 'B';
        }
        else if (grade >= 70)
        {
            letter = 'C';
        }
        else if (grade >= 60)
        {
            letter = 'D';
        }
        else
        {
            letter = 'F';
        }

        bool isSignedGrade = IsSignedGrade(grade);

        if (isSignedGrade)
        {
            char sign = GetSign(grade);

            Console.WriteLine($"You got a grade of {letter}{sign}.");
        } 
        else
        {
            Console.WriteLine($"You got a grade of {letter}.");
        }

        if (grade >= 70)
        {
            Console.WriteLine("Congratulations, you passed the class!");
        }
        else
        {
            Console.WriteLine("It looks like you didn't pass the class. Study harder next time!");
        }
    }

    static bool IsSignedGrade(int grade)
    {
        if (grade >= 94 || grade < 60)
        {
            return false;
        }

        if (grade % 10 <= 3 || grade % 10 >= 7)
        {
            return true;
        }

        return false;
    }

    static char GetSign(int grade)
    {
        if (grade % 10 <= 3)
        {
            return '-';
        }
        else
        {
            return '+';
        }
    }
}