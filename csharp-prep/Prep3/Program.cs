using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep3 World!");

        bool playAgain = true;

        while (playAgain)
        {
            Random random = new Random();
            // Generates a number between 1 and 100
            int magicNumber = random.Next(1, 101); 

            int guess = 0;
            int guessCount = 0;

            while (guess != magicNumber)
            {
                // Asking for a guess
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                guessCount++;

                // Higher, lower, or correct
                if (guess > magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess < magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine($"You guessed it in {guessCount} guesses!");
                }
            }

            // Asking to play again
            Console.Write("Do you want to play again? (Y/N): ");
            string response = Console.ReadLine().ToLower();
            playAgain = (response == "y" || response == "Y");
        }

    }
}