
using System.Threading.Tasks;

namespace WaitersApp
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            var tableServices = new TableServices();
            var foodRepo = new FoodRepository();
            var drinkRepo = new DrinksRepository();
            var orderRepo = new OrderRepository();
            var emailSender = new EmailSender();
            var input = new UserInputValidation();
            StandartMessages.WelcomeMessage(); //welcome
            tableServices.ShowTablesList(); //aviable tables
            StandartMessages.SyntaxSugar();
            orderRepo.MakeOrder(tableServices.TablesList[2], foodRepo.FoodList[0], drinkRepo.DrinkList[1]);
            //orderRepo.MakeOrder(tableServices.TablesList[2], foodRepo.FoodList[3]); //overloaded method order methods
            //orderRepo.MakeOrder(tableServices.TablesList[2], drinkRepo.DrinkList[3]);
            tableServices.ShowTablesList(); //tables with order marked as taken
            var rec = new Receipt(tableServices.TablesList[2]);
            tableServices.CreateReceiptForRestaurant(rec); //receipt for restaurant
            tableServices.CreateReceiptForClient(rec, 'y', 40.40m); //receipt for client
            tableServices.SetTableFree(tableServices.TablesList[2]); // makes table free
            tableServices.ShowTablesList(); // free tables aviable
            emailSender.SendEmail(rec); //email for client or restourant 
            StandartMessages.EndApplication();
            //var appBody = new ApplicationBody();
            //appBody.Run();
        }

    }
}
