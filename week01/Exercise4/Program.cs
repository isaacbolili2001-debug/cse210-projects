using System;

class Program
{
    static void Main(string[] args)
    {
        int AddNumbers(int a, int b)
        {
            int sum = a + b;
            return sum;
        }
        int result = AddNumbers(5, 10);
        Console.WriteLine("The sum is: " + result);
    }
}