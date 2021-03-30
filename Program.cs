using System;

namespace GuessingGame
{
    class Program
    {
        static void Main()
        {
            bool GuessedCorrect = false;
            Random randNum = new Random();
            int RandomValue = randNum.Next(1, 101);
            int GuessCount = 0;
            Console.WriteLine("Guess a random Number between 1 and 100");
            do
            {
                Console.Write("Guess: ");
                int PlayerGuess = int.Parse(Console.ReadLine());
                if (PlayerGuess == RandomValue)
                {
                    GuessedCorrect = true;
                    Console.WriteLine("You win! You guessed the number right! {0}", PlayerGuess);
                    ++GuessCount;
                }
                else if (PlayerGuess > RandomValue)
                {
                    Console.WriteLine("Guess Lower!");
                    ++GuessCount;
                }
                else if (PlayerGuess < RandomValue)
                {
                    Console.WriteLine("Guess Higher!");
                    ++GuessCount;
                }
            }

            while (!GuessedCorrect);
            Console.WriteLine("You guess {0} amount of times", GuessCount);
            if (GuessCount < 10)
            {
                Console.WriteLine("Either you know the secret or you got lucky!");
            }
            else if (GuessCount == 10)
            {
                Console.WriteLine("Aha! You know the secret");
            }
            else if (GuessCount > 10)
            {
                Console.WriteLine("You should be able to do better!");
            }
            Console.WriteLine("The trick to the guessing game is to first guess the middle number");
            Console.WriteLine("If the number is higher, guess inbetween the highest number and your first number guessed");
            Console.WriteLine("if the number is lower, guess inbetween the lowest number and your first number guessed");
            Console.WriteLine("Continue doing this with each number, cutting the number in the middle between number guessed and max or min value");
            Console.WriteLine("Doing this should beable to guess the number in fewer than 10 tries");

            Console.ReadKey();
        }
    }
}



