using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int year = PromtUserBirthYear();
        int squaredNumber = SquareNumber(number);
        
        DisplayResult(name, squaredNumber, year);
    }

    static void DisplayWelcome() {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName() {
        Console.Write("Please enter your name: ");

        return Console.ReadLine();
    }

    static int PromptUserNumber() {
        Console.Write("Please enter your favorite number: ");

        return int.Parse(Console.ReadLine());
    }

    static int PromtUserBirthYear() {
        Console.Write("Please enter the year you were born: ");

        return int.Parse(Console.ReadLine());
    }

    static int SquareNumber(int number) {
        int squared = number * number;

        return squared;
    }

    static void DisplayResult(string name, int squaredNumber, int birthYear) {
        Console.WriteLine($"{name}, the square of your number is {squaredNumber}");

        DateOnly today = DateOnly.FromDateTime(DateTime.Today);
        int age = today.Year - birthYear;
        Console.WriteLine($"{name}, you will turn {birthYear} this year");
    }
}