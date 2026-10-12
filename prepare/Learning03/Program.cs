using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction oneOverOne = new Fraction();
        Fraction sixOverOne = new Fraction(6);
        Fraction threeFourths = new Fraction(3, 4);
        Fraction oneThird = new Fraction(1, 3);

        Console.WriteLine("String representations");

        Console.WriteLine(oneOverOne.GetFractionAsString());
        Console.WriteLine(sixOverOne.GetFractionAsString());
        Console.WriteLine(threeFourths.GetFractionAsString());
        Console.WriteLine(oneThird.GetFractionAsString());

        Console.WriteLine("\nDecimal representations");

        Console.WriteLine(oneOverOne.GetFractionAsDecimal());
        Console.WriteLine(sixOverOne.GetFractionAsDecimal());
        Console.WriteLine(threeFourths.GetFractionAsDecimal());
        Console.WriteLine(oneThird.GetFractionAsDecimal() + "\n");

        Fraction fractionTestSubject = new Fraction();
        Random random = new Random();

        for (int i = 0; i < 20; i++)
        {
            int numerator = random.Next(100);
            int denominator = random.Next(100);

            fractionTestSubject.SetNumerator(numerator);
            fractionTestSubject.SetDenominator(denominator);

            Console.WriteLine($"Fraction {i + 1}: String: {fractionTestSubject.GetFractionAsString()}, Number: {fractionTestSubject.GetFractionAsDecimal()}");
        }
    }
}