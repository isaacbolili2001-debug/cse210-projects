using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your age ?: ");
        string userInput = Console.ReadLine();
        int number = int.Parse(userInput);
        Console.WriteLine($"Your age is {number}.");
    }
}