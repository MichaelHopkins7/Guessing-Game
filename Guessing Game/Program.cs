using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guessing_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Bisection bisect = new Bisection();
            HumanGuess iGuess = new HumanGuess();
            ComputerGuess uGuess = new ComputerGuess();
            int userChoice;
            do
            {
                Console.WriteLine("Would you like to play:");
                Console.WriteLine("1. Computer Interger Bisection.");
                Console.WriteLine("2. Human Guesses Number");
                Console.WriteLine("3. Computer Guesses Number");
                Console.WriteLine("or 0 to quit");
                userChoice = Utility.GetInt(3);
                switch (userChoice)
                {
                    case 0:
                        {
                            break;
                        }
                    case 1:
                        {
                            bisect.DoBisection();
                            break;
                        }
                    case 2:
                        {
                            iGuess.Guess();
                            break;
                        }
                    case 3:
                        {
                            uGuess.ComGuess();
                            break;
                        }
                }
            }
            while (userChoice != 0);
        }
    }
}
