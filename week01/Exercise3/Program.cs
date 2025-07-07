using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        string play;

        do
        {
            // Get a random number
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(1, 101);

            int guess;
            int count = 0;

            do
            {
                Console.Write("Enter your guess: ");
                guess = int.Parse(Console.ReadLine());
                count++;

                if (guess > number)
                {
                    Console.WriteLine("Lower");
                }
                else if (guess < number)
                {
                    Console.WriteLine("Higher");
                }
            } while (guess != number);

            Console.WriteLine("You guessed it!");
            Console.WriteLine($"Number of guesses: {count}");

            Console.WriteLine("Continue Play? (yes or no): ");
            play = Console.ReadLine();
        } while (play == "yes");
    }
}