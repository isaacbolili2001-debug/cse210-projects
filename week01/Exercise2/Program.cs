using System;

class Program
{
    static void Main(string[] args)
    {
       Console.WriteLine("Welcome To the guessing Game");
       string playing = "yes";
       while (playing == "yes")
        {
            Random random = new Random();
            int magicNumber = random.Next(1, 101); // Generates a random number between 1 and 100
            int guessAccount = 0;
            int guess = -1;

            while (guess != magicNumber)
            {
                Console.WriteLine("Guess the number between 1 and 100:");
                string userInput=Console.ReadLine();
                int number = int.Parse(userInput);
                guessAccount +=1;
                if (number < magicNumber)
                {
                    Console.WriteLine("higher");
                }
                else if (number > magicNumber)
                {
                    Console.WriteLine("lower");
                }
                else
                {
                    Console.WriteLine("you guessed it");
                }
            }
            Console.WriteLine($"it took you {guessAccount} guesses");


        }
      

    }
}