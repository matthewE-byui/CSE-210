using System;
using System.Drawing;
using System.Runtime.CompilerServices;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Hello World! 2");
//         Console.WriteLine("hey YO!");
//     }
// }

// while loops v

// string response = "yes";
// while (response == "yes")
// {
//     Console.Write("Do you want to continue?");
//     response = Console.ReadLine();
// }

// Do while loops v

// String response;

// do 
// {
//     Console.Write("Do you want to continue? ");
//     response = Console.ReadLine();

// }while (response == "yes");

// for loops v

// for (int i = 2; i < 20; i++)
// {
//     Console.Write(i);
// }

// foreach loops v

// foreach (string color in color)
// {
//     Console.WriteLine(color);
// }

// Random number generation v

// Random randomGenerator == new Random();
// int number = randomGenerator.Next(1,11);

// loop program

class Program
{
    static void Main()
    {
        string playAgain = "yes";

        while (playAgain.ToLower() == "yes")
        {
            Random random = new Random();
            int magicNumber = random.Next(1, 101);
            int guess = -1;
            int guessCount = 0;

            Console.WriteLine("I'm thinking of a number between 1 and 100...");

            while (guess != magicNumber)
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                guessCount++;

                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine($"You guessed it in {guessCount} tries!");
                }
            }

            Console.Write("Do you want to play again? (yes/no): ");
            playAgain = Console.ReadLine();
        }

        Console.WriteLine("Thanks for playing!");
    }
}
