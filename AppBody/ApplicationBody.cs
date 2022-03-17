using System;

namespace WaitersApp
{
    public class ApplicationBody
    {
        public void Run()
        {
            var tableServices = new TableServices();
            var foodRepo = new FoodRepository();
            var drinkRepo = new DrinksRepository();
            var orderRepo = new OrderRepository();
            var emailSender = new EmailSender();
            var input = new UserInputValidation();
            bool isAlive = true;
            var receipt = new Receipt();
            while (isAlive)
            {

                Console.WriteLine("1.Show aviable tables\n2.Show menu\n3.Make order\n4.Create receipt for restaurant\n5.Create receipt for restaurant\n6.Send email\n7.Clear console\n8.Exit");
                var menuInput = input.UserInputForInts();
                if (menuInput == 1) tableServices.ShowTablesList();
                if (menuInput == 2)
                {
                    foodRepo.ShowFoodMenu();
                    drinkRepo.ShowDrinksMenu();
                };
                if (menuInput == 3)
                {
                    Console.WriteLine("1.Make oder for food and drink \n 2.Make order for food \n 3.Make order for drink");
                    var orderInput = input.UserInputForInts();
                    if (orderInput == 1)
                    {
                        Console.WriteLine("Pick table, pick food, pick drink");
                        orderRepo.MakeOrder(tableServices.TablesList[input.UserInputForInts()], foodRepo.FoodList[input.UserInputForInts()], drinkRepo.DrinkList[input.UserInputForInts()]);
                    }
                    if (orderInput == 2)
                    {
                        Console.WriteLine("Pick table, pick food");
                        orderRepo.MakeOrder(tableServices.TablesList[input.UserInputForInts()], foodRepo.FoodList[input.UserInputForInts()]);
                    }
                    if (orderInput == 3)
                    {
                        Console.WriteLine("Pick table, pick drink");
                        orderRepo.MakeOrder(tableServices.TablesList[input.UserInputForInts()], drinkRepo.DrinkList[input.UserInputForInts()]);
                    }
                };
                if (menuInput == 4)
                {
                    Console.WriteLine("Pick a table for receipt");
                    var rec = new Receipt(tableServices.TablesList[input.UserInputForInts()]);
                    tableServices.CreateReceiptForRestaurant(rec);
                };
                if (menuInput == 5)
                {
                    Console.WriteLine("Pick a table for receipt");
                    Console.WriteLine("Do you need receipt y/n?");
                    Console.WriteLine("Enter paid amount");
                    var rec = new Receipt(tableServices.TablesList[input.UserInputForInts()]);
                    tableServices.CreateReceiptForClient(rec, input.InputForChar(),input.InputForDecimal());
                    receipt = rec;
                };
                if (menuInput == 6)
                {
                    Console.WriteLine("Pick a table for email");
                    var rec = new Receipt(tableServices.TablesList[input.UserInputForInts()]);
                    emailSender.SendEmail(receipt);
                };
                if (menuInput == 7) Console.Clear();
                if (menuInput == 8) isAlive = false;
            }


        }


    }
}
