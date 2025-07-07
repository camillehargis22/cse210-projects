using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise1 Project.");

        // Get the first name
        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine();

        // Get the last name
        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();

        // Print extra line
        Console.WriteLine("");

        // Print name
        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}");
    }
}