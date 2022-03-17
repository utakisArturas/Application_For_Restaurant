using System;

namespace WaitersApp
{
    public class StandartMessages
    {
        public static void WelcomeMessage()
        {   
            var time = DateTime.Now;
            Console.WriteLine($"Ordering Application\n{time}");
        }
        public static void EndApplication()
        {
            Console.ReadLine();
        }
        public static void ChooseTable()
        {
            Console.WriteLine("Choose table for ordering");
        }
        public static void SyntaxSugar()
        {
            Console.WriteLine("--------------------------------------------------------\n--------------------------------------------------------");

        }
        public static void PickMenu()
        {
            Console.WriteLine("Pick menu : 1. Food menu 2. Drinks menu");
        }
        public static void IncorrectInputRange()
        {
            Console.WriteLine("Incorrect input range");
        }
        public static void IncorrectInputType()
        {
            Console.WriteLine("Incorrect input type.Try again");
        }
        public static void MakeAnOrder()
        {
            Console.WriteLine("Make your order");
        }
        public static void EnterAmountPaid()
        {
            Console.WriteLine("Enter paid amount");
        }
    }
}
