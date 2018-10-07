using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guessing_Game
{
    class Utility
    {
        public static int GetInt(int maxNum)
        {
            int value;
            string input = Console.ReadLine();
            do
            {
                if (int.TryParse(input, out value))
                {
                    if (value > maxNum || value < 0)
                    {
                        Console.WriteLine($"Please enter a valid integer equal to or less than {maxNum}.");
                        input = Console.ReadLine();
                    }
                    else
                    {
                        return value;
                    }
                }
                else
                {
                    Console.WriteLine("Please enter the number of your choice");
                    input = Console.ReadLine();
                }
            }
            while (true);
        }

        public static bool isGreater(int target, int guess)
        {
            if (target > guess)
                return true;
            else
            {
                return false;
            }
        }


    }
}
