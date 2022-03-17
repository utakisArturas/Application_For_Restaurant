using System;
using System.IO;
using System.Linq;

namespace WaitersApp
{
    public class TableServices : TableRepository
    {
        public void ShowTablesList()

        {
            var aviableTables = TablesList.Where(t => t.IsFree == true).ToList();
            aviableTables.ForEach(t => Console.WriteLine(t));
        }
        public void SetTableTaken(Table table)
        {
            table.IsFree = false;
            
        }
        public void SetTableFree(Table table)
        {
            table.IsFree = true;
            
        }
        public void CreateReceiptForRestaurant(Receipt receipt)
        {
            TextWriter text = new StreamWriter($@"C:\Receipt\tableNumber{receipt.ReceiptId}.txt");
            text.WriteLine($"Table:{receipt.ReceiptId}\nSeats({receipt.Table.NumberOfSeats})\n");
            receipt.foods.ForEach(food => text.WriteLine($"{food}"));
            receipt.drinks.ForEach(drink => text.WriteLine($"{drink}"));
            text.WriteLine($"Total price:{receipt.TotalPrice}Eur\n{DateTime.Now}");
            text.Close();
        }
        public void CreateReceiptForClient(Receipt receipt,Char yesNo,decimal amountPaid)
        {
            if (yesNo == 'y')
            {   
                receipt.AmountPaid = amountPaid;
                StandartMessages.SyntaxSugar();
                Console.WriteLine($"Table:{receipt.ReceiptId}\nSeats({receipt.Table.NumberOfSeats})\n");
                StandartMessages.SyntaxSugar();
                receipt.foods.ForEach(food => Console.WriteLine($"{food}"));
                receipt.drinks.ForEach(drink => Console.WriteLine($"{drink}"));
                StandartMessages.SyntaxSugar();
                Console.WriteLine($"Total price: {receipt.TotalPrice}Eur\nPaid: {amountPaid}Eur\nChange: {amountPaid-receipt.TotalPrice}Eur\n{DateTime.Now}");
            }
            Console.WriteLine("Than you for eating");
            
        }

    }
}
