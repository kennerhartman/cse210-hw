using System;

class Program
{

    static void Main(string[] args)
    {
        // while loops

        // bool done = false;

        // while (!done)
        // {
        //     Console.Write("Are we done? (y/n): ");
        //     done = Console.ReadLine().ToLower() == "y";
        // }

        // do-while loops

        // bool done;

        // do
        // {
        //     Console.Write("Are we done? (y/n): ");
        //     done = Console.ReadLine().ToLower() == "y";
        // } while (!done);

        // for loops

        // Random random = new Random();
        // int randomNumber = random.Next(1, 1000);

        // for (int i = 100000; i > 0; i -= randomNumber)
        // {
        //     Console.WriteLine(i);
        //     randomNumber = random.Next(1, 1000);
        // }

        // lists & foreach loops

        // List<object> objects = new List<object>();

        // objects.Add("Value");
        // objects.Add(0);
        // objects.Add(0.23423);

        // foreach (object item in objects)
        // {
        //     Console.WriteLine(item);
        // }

        // Console.WriteLine($"There are {objects.Count()} objects in the list!");

        // functions/methods

        Console.WriteLine(AddNumbers(0.34234, 0.20342));
    }

    static double AddNumbers(double x, double y)
    {
        return x + y;
    }

}