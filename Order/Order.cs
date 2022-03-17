namespace WaitersApp
{
    public class Order
    {
        public Food OrderedFood { get; set; }
        public Drink OrderedDrink { get; set; }
        public int OrderId { get; set; }
        public decimal TotalPrice { get; set; }

        public Order(Food orderedFood, Drink orderedDrink, Table table)
        {
            OrderedFood = orderedFood;
            OrderedDrink = orderedDrink;
            OrderId = table.Id;
            TotalPrice += orderedFood.Price + orderedDrink.Price;
        }
        public Order(Food orderedFood, Table table)
        {
            OrderedFood = orderedFood;
            OrderId = table.Id;
            TotalPrice += orderedFood.Price;
        }
        public Order(Drink orderedDrink, Table table)
        {
            OrderedDrink = orderedDrink;
            OrderId = table.Id;
            TotalPrice += orderedDrink.Price;
        }
    }
}

