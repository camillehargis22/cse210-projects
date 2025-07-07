using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise1 Project.");

        // Get the first name
        Console.Write("What is your first name? ");
        string first_name = Console.ReadLine();

        // Get the last name
        Console.Write("What is your last name? ");
        string last_name = Console.ReadLine();

        // Print extra line
        Console.WriteLine("");

        // Print name
        Console.WriteLine($"Your name is {last_name}, {first_name} {last_name}");
    }
}