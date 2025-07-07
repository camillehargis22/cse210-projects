using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");

        // Display Welcome Funtion
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        // Prompt User Name function, gets user name from console
        static string PromptUserName()
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            return name;
        }

        // Prompt user number function, gets users favorite number from console
        static int PromptUserNumber()
        {
            Console.Write("Enter your favorite number: ");
            int number = int.Parse(Console.ReadLine());
            return number;
        }

        // Square Number funtion, squares the users favorite number
        static int SquareNumber(int number)
        {
            return number * number;
        }

        // Display Result function, displays the users name and favorite number squared
        static void DisplayResult(string name, int number)
        {
            Console.WriteLine($"{name}, the square of your number is {number}");
        }

        // Call each function
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int squared = SquareNumber(number);
        DisplayResult(name, squared);
    }
}