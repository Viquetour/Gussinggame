using System;

namespace GuessGame
{
    class Program
    {
        static void Main(string[] args)
            
        {
            bool isCorrectGuess = false;
            Random random = new Random();

            int randomNum = random.Next(1, 11);

            Console.WriteLine("Welcome to the number guessing game!!");
            Console.WriteLine("A random number will be generated from 1 to 10");
            Console.WriteLine("if you guess correctly you win!!");

            while (!isCorrectGuess)
            {
                Console.WriteLine("enter you guess number");
                int guess = Convert.ToInt32(Console.ReadLine());

                if(guess < randomNum)
                {
                    Console.WriteLine("guess to Low!!");
                }
                else if(guess > randomNum)
                {
                    Console.WriteLine("guess too high!!");
                }
                else
                {
                    Console.WriteLine("Guess correct!!");
                    isCorrectGuess = true;
                }
            }
            Console.WriteLine("you win!!");
            Console.ReadKey();
        }
    }
}