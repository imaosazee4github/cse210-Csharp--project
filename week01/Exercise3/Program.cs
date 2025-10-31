using System;

class Program
{
    static void Main(string[] args)
    {
        Random rand = new Random();
        string playGame = "yes";

        //a for loop for replaying the game

        for (; playGame == "yes";)
        {
            int magicNumber = rand.Next(1, 101); //random from 1 - 100
            int guess = -1;
            int attempts = 0;

           Console.WriteLine("Think of a number between 1 and 100. ");
             
             //inner loop for guessing

             for (; guess != magicNumber;)
             {
                Console.Write("What is your guess? ");
                string guessItem = Console.ReadLine();
                guess =  int.Parse(guessItem);
                attempts++;

                if (guess < magicNumber)
                    Console.WriteLine("Higher");

                else if (guess > magicNumber)
                    Console.WriteLine("Lower");

                else {
                    Console.WriteLine($"You guessed it! it took you {attempts} guesses. ");

                }
              
             }

             Console.Write("Do you want to play again? (yes/no): ");
             playGame = (Console.ReadLine() ?? "no").Trim(). ToLower();
             Console.WriteLine();
        }

        Console.WriteLine("Thanks for playing");
        
    }
}