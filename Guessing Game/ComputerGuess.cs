using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guessing_Game
{
    class ComputerGuess
    {
        
        public void ComGuess()
        {
            int min = 1;
            int max = 100;
            int between;
            int input;
            int counter = 0;
            Console.WriteLine("Think of a number from 1 to 100.  The computer will try to guess it.  Keep the same number until the computer guesses" +
                " correctly what your number is.");
            Console.WriteLine("Enter 1 if your number was less than the computer's guess,");
            Console.WriteLine("2 if your number was the computer's guess,");
            Console.WriteLine("3 if your number was greater than the computer's guess,");
            Console.WriteLine($"or 0 to quit.\n");
            do
            {
                between = (max - min) / 2;
                Console.WriteLine($"Is your number {min + between}?");
                input = Utility.GetInt(3);
                if (input == 2)
                {
                    counter++;
                    Console.WriteLine($"The computer took {counter} guesses to get the number.");
                    input = 0;
                    Console.ReadLine();
                }
                else if (input == 1)
                {
                    counter++;
                    max = min + between - 1;
                }
                else if (input == 3)
                {
                    counter++;
                    min = min + between + 1;
                }
                if (max < min)
                {
                    Console.WriteLine("You must have made a mistake at some point when telling the computer if your number was less than or greater than" +
                        "the guess from the computer.");
                    input = 0;
                    Console.ReadLine();
                }
            }
            while (input != 0);
            
        }
    }
}
