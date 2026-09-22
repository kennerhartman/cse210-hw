using System;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        
        int largestNumber = 0;
        int smallestPositiveNumber = -1;

        while (true)
        {
            Console.Write("Enter Number: ");

            string numberString = Console.ReadLine();
            int number = int.Parse(numberString);

            if (number == 0)
            {
                break;
            }

            numbers.Add(number);

            if (number > largestNumber)
            {
                largestNumber = number;
            }

            if (number > 0 && smallestPositiveNumber == -1)
            {
                smallestPositiveNumber = number;
            }

            if (number > 0 && number < smallestPositiveNumber)
            {
                smallestPositiveNumber = number;
            }
        }

        int total = 0;

        foreach (int number in numbers)
        {
            total += number;
        }

        float average = ((float) total) / numbers.Count;

        Console.WriteLine($"The sum is: {total}.");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is {largestNumber}.");
        Console.WriteLine($"The smallest positive number is {smallestPositiveNumber}.");
        
        Console.WriteLine("The sorted list is:");

        List<int> sortedNumbers = numbers.OrderBy(n => n).ToList();
        foreach (int number in sortedNumbers)
        {
            Console.WriteLine(number);
        }
    }
}