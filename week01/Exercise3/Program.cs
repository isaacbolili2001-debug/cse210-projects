using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.Write("Enter add a number or (type '0' to finish):");
        int userInput = Convert.ToInt32(Console.ReadLine());
        while (userInput != 0)
        {
            numbers.Add(userInput);
            Console.Write("Enter add a number or (type '0' to finish):");
            userInput = Convert.ToInt32(Console.ReadLine());
        }
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
           
        }
        int average = numbers.Sum() / numbers.Count();
        Console.WriteLine("Average: " + average);

        int smallest = numbers.Min();
        Console.WriteLine("Smallest: " + smallest);

        int largest = numbers.Max();
        Console.WriteLine("Largest: " + largest);
    }
}