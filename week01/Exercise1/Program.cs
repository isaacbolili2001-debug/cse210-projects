using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise1 Project.");
        string first_name;
        string last_name;
        Console.WriteLine("Please enter your first name:");
        first_name = Console.ReadLine();
        Console.WriteLine("Please enter your last name:");
        last_name = Console.ReadLine();
        Console.WriteLine($"Hello dear {first_name} {last_name}, welcome to the C# programming world!");

    }
}