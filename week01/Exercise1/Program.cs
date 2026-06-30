using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise1 Project.");
        string firstName;
        string lastName;
        Console.WriteLine("Please enter your first name:");
        firstName = Console.ReadLine();
        Console.WriteLine("Please enter your last name:");
        lastName = Console.ReadLine();
        Console.WriteLine($"Hello dear {firstName} {lastName}, welcome to the C# programming world!");

    }
}