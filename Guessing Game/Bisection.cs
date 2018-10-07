using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guessing_Game
{
    class Bisection
    {
        public void DoBisection()
        {
            int[] sorted = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            bool noGood = true;
            int min = 0;
            int mid = 5;
            int max = 9;
            Console.WriteLine("Enter an interger between 1 and 10 for the computer to work throuh, or 0 to return to main menu.");
            int userIn = Utility.GetInt(10);
            if (userIn == 0)
            {
                return;
            }
           

            Console.WriteLine("The First step is to find the middle number.");
            Console.WriteLine("We do this by dividing the array length in half and rounding down.");
            Console.WriteLine($"In this case the array is 10 items so we divide 10 by 2 and get 5 meaning that" +
                " we want the fifth element of the array. So to account for arrays starting at 0 we subtract 1 " +
                "before dividing so our start point reflects 0 being an element.");
            mid = mid = (sorted.Length - 1) / 2;
            Console.WriteLine($"mid = (sorted.Length -1) / 2; or {mid}");
            Console.ReadLine();
            Console.WriteLine("Then we start the search there checking to see if we have the chosen number or" +
                " if we were to high or to low using a simple if else statement.  Because we need to repeat this" +
                " process as many times as nessesary it is put inside a do loop.");
            Console.ReadLine();

            do
            {
                Console.WriteLine($"Then we check if our middle point is the number ArrayName[mid] or {sorted[min + mid]}.");
                Console.WriteLine("We do this by using if else if else else.");
                Console.WriteLine("Checking user's number verses our current mid represented by min + mid.");

                if (userIn == sorted[min + mid])
                {
                    Console.WriteLine($"The Middle Point is the number! The number is {sorted[min + mid]}");
                    noGood = false;
                }
                else if (sorted[min + mid] > userIn)
                {
                    Console.WriteLine($"The Middle Point farther along the array than the number.");
                    Console.WriteLine("So now we will change our search area to numbers below our guess" +
                        "by setting the top of our searchable area to 1 less than our current midpoint. We " +
                        "subtract 1 to remove our midpoint from the searched numbers.");
                        max = (min + mid) - 1;
                    Console.WriteLine($"max = (min + mid) - 1; which gives us {max}");
                    Console.ReadLine();
                    Console.WriteLine("Then we find how far between the two the midpoint is.");
                    mid = (max - min) / 2;
                    Console.WriteLine($"mid = (max - min) / 2; which gives us {mid}");
                    Console.ReadLine();
                }
                else if (sorted[min + mid] < userIn)
                {
                    Console.WriteLine($"The Middle Point earlier in the array than the number.");
                    Console.WriteLine("So now we will change our search area to numbers above our guess" +
                        "by setting the bottom of our searchable area to 1 more than our current midpoint. We " +
                        "add one 1 to remove our midpoint from the searched numbers.");
                    min = (min + mid) + 1;
                    Console.WriteLine($"min = (min + mid) + 1; which gives us {min}");
                    Console.ReadLine();
                    Console.WriteLine("Then we find how far between the two the midpoint is.");
                    mid = (max - min) / 2;
                    Console.WriteLine($"mid = (max - min) / 2; which gives us {mid}");
                    Console.ReadLine();
                }
            }
            while (noGood);
            
            Console.ReadLine();

            return;
        }

    }
}
