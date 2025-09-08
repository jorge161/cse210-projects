using System;
using System.Net;

class Program
{
    static void Main(string[] args)
     {
        string response = "yes";
        int number = 0;
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 5);

        while (response == "yes")
        {
            number += 1;

            Console.WriteLine("What is your guess?");
            string guess = Console.ReadLine();
            int guessNumber = int.Parse(guess);

            if (magicNumber > guessNumber)
            {
                Console.WriteLine("Too low. Try again.");
            }
            else if (magicNumber < guessNumber)
            {
                Console.WriteLine("Too high. Try again.");
            }
            else
            {
                Console.WriteLine($"You guessed it! you tryd {number} times");
                magicNumber = randomGenerator.Next(1, 5);
                number = 0;

            }

            Console.Write("Do you want to play again? (yes/no) ");
            response = Console.ReadLine();

            if (response != "yes")                       
            {
                Console.WriteLine("Goodbye, thanks for playing");
            }
            


        }
    }
}