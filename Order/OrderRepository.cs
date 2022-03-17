
namespace WaitersApp
{
    public class OrderRepository :TableRepository
    {
        public Order MakeOrder(Table table,Food food, Drink drink )
        {
            var tempOrder = new Order(food,drink,table);
            table.TablesOrder.Add(tempOrder);
            table.IsFree = false;
            return tempOrder;
        }
        public Order MakeOrder(Table table,Food food)
        {
            var tempOrder = new Order(food,table);
            table.TablesOrder.Add(tempOrder);
            table.IsFree = false;
            return tempOrder;
        }
        public Order MakeOrder(Table table,Drink drink)
        {
            var tempOrder = new Order(drink,table);
            table.TablesOrder.Add(tempOrder);
            table.IsFree = false;
            return tempOrder;
        }
    }
}
