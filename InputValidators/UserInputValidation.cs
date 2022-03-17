
using System;

namespace WaitersApp
{
    public class UserInputValidation
    {
        public int UserInputForInts()
        {
            int X;

            String Result = Console.ReadLine();

            while (!Int32.TryParse(Result, out X))
            {
                Console.WriteLine($"Not a valid number, try again.\nYour input type was{Result.GetType()}");

                Result = Console.ReadLine();
            }
            return Convert.ToInt32(Result);
        }
        public Char InputForChar()
        {
            String Result = Console.ReadLine().ToLower();

            while (Result != "y")
            {
                Console.WriteLine("Wrong input. Type y for receipt");
                Result = Console.ReadLine();
            }
            return Convert.ToChar(Result);
        }
        public Decimal InputForDecimal()
        {
            decimal X;

            String Result = Console.ReadLine();

            while (!decimal.TryParse(Result, out X))
            {
                Console.WriteLine($"Not a valid decimal number, try again.\nYour input type was{Result.GetType()}");

                Result = Console.ReadLine();
            }
            return Convert.ToDecimal(Result);
        }
        public int InputForIntFromZeroToFour(int number)
        {
         Console.WriteLine("Enter number from 0-4");
            if (number != 0)
            {
                Console.WriteLine($"Wrong input range.Your input{number}");
            }
            else if (number != 1)
            {
                Console.WriteLine($"Wrong input range.Your input{number}");
            }
            else if (number != 2)
            {
                Console.WriteLine($"Wrong input range.Your input{number}");
            }
            else if (number != 3)
            {
                Console.WriteLine($"Wrong input range.Your input{number}");
            }
            else if (number != 4)
            {
                Console.WriteLine($"Wrong input range.Your input{number}");
            }
            return number;
        }
    }
}
