using LINQtoCSV;


namespace WaitersApp
{
    public class Drink
    {
        [CsvColumn(Name = "Name")]
        public string Name { get; set; }

        [CsvColumn(Name = "Price")]
        public decimal Price { get; set; }

        public override string ToString()
        {
            return $"{Name} -  {Price}EUR";
        }
    }
}
