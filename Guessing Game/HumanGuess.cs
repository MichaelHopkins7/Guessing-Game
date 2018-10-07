using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guessing_Game
{
    class HumanGuess
    {
        int comNum;
        Random ranGen = new Random();
        int playerGuess;
        string input;
        int counter;

        public void Guess()
        {
            Console.WriteLine("The computer has made a number between 1 and 1000, give your first guess.  Or 0 to quit.");
            comNum = ranGen.Next(1, 1000);
            counter = 0;
            do
            {
                input = Console.ReadLine();
                if (int.TryParse(input, out playerGuess))
                {
                    if (playerGuess > 1000 || playerGuess < 0)
                    {
                        Console.WriteLine($"Please enter a valid integer 1 and 1000 or 0 to quit.");
                    }
                    else if (playerGuess == comNum)
                    {
                        counter++;
                        Console.WriteLine($"You guessed the number!");
                        Console.WriteLine($"It took you {counter} guesses.");
                        playerGuess = 0;
                    }
                    else if (playerGuess < comNum)
                    {
                        counter++;
                        Console.WriteLine("Your guess was too low.");
                    }
                    else if (playerGuess > comNum)
                    {
                        counter++;
                        Console.WriteLine("Your guess was too high.");
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a valid integer between 1 and 1000 or 0 to quit.");
                }
            }
            while (playerGuess != 0);

        }
    }
}
