using System.Collections.Generic;


namespace WaitersApp
{
    public class Table
    {
        public int Id { get; set; }
        public int NumberOfSeats { get; set; }
        public bool IsFree { get; set; }
        public List<Order> TablesOrder { get; set; }

        public Table(int id, int numberOfSeats, bool isFree)
        {
            Id = id;
            NumberOfSeats = numberOfSeats;
            IsFree = isFree;
            TablesOrder = new List<Order>();
        }
        public override string ToString()
        {
            return $"Table number: {Id}. Seats : {NumberOfSeats}. Table is aviable : {IsFree}";

        }


    }
}
