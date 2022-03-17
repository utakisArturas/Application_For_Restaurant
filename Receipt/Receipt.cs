
using System.Collections.Generic;
using System.Linq;


namespace WaitersApp
{
    public class Receipt
    {
        public Table Table { get; set; }
        public decimal TotalPrice { get; set; }
        public int ReceiptId { get; set; }

        public List<Food> foods = new List<Food>();

        public List<Drink> drinks = new List<Drink>();
        public decimal AmountPaid { get; set; }

        public Receipt()
        {

        }
        public Receipt(Table table)
        {
            Table = table;
            ReceiptId = table.Id;
            table.TablesOrder.ForEach(Order => foods.Add(Order.OrderedFood));
            table.TablesOrder.ForEach(order1 => drinks.Add(order1.OrderedDrink));
            TotalPrice = table.TablesOrder.Select(order => order.TotalPrice).Sum();
            AmountPaid = 0;
        }


    }
}
