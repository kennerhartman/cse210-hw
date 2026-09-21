using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int number = random.Next(1, 100);

        int numberOfGuesses = 0;

        while (true)
        {
            Console.Write("What is your guess? ");

            string guessString = Console.ReadLine();
            int guess = int.Parse(guessString);

            if (guess < number) 
            {
                Console.WriteLine("Higher!");
            }
            else if (guess > number)
            {
                Console.WriteLine("Lower!");
            }
            else
            {
                ++numberOfGuesses;

                Console.WriteLine($"You guessed it in {numberOfGuesses} guesses!");

                Console.WriteLine("Want to play again? y/n");

                string response = Console.ReadLine();

                if (response == "y")
                {
                    numberOfGuesses = 0;
                    number = random.Next(1, 100);
                    continue;
                }

                break;
            }

            ++numberOfGuesses;
        }
    }
}