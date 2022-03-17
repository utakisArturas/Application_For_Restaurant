using WaitersApp;
using Xunit;

namespace OrdersTests
{
    public class OrderTests
    {
        [Fact]
        public void Test_If_Returns_Order_Object()
        {
            // ARRANGE
            var food = new Food();
            var drink = new Drink();
            var table = new Table(1,4,true);
            var orderRepository = new OrderRepository();

            // ACT
            orderRepository.MakeOrder(table, food, drink);
            // ASSERT
            Assert.IsType<Order>(orderRepository.MakeOrder(table, food, drink));
        }
        [Fact]
        public void Test_If_Returns_Order_Object1()
        {
            // ARRANGE
            var food = new Food();
            var drink = new Drink();
            var table = new Table(1, 4, true);
            var orderRepository = new OrderRepository();

            // ACT
            orderRepository.MakeOrder(table, food);
            // ASSERT
            Assert.IsType<Order>(orderRepository.MakeOrder(table, food));
        }
        [Fact]
        public void Test_If_Returns_Order_Object2()
        {
            // ARRANGE
            var food = new Food();
            var drink = new Drink();
            var table = new Table(1, 4, true);
            var orderRepository = new OrderRepository();

            // ACT
            orderRepository.MakeOrder(table,drink);
            // ASSERT
            Assert.IsType<Order>(orderRepository.MakeOrder(table,drink));
        }
    }
}