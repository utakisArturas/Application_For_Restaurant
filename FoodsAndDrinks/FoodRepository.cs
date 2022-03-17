using LINQtoCSV;
using System.Collections.Generic;
using System.Linq;
using System;


namespace WaitersApp
{
    public class FoodRepository : Food
    {
        public List<Food> FoodList = ReadFoodCsvService();

        public static List<Food> ReadFoodCsvService()
        {
            var csvFileDescription = new CsvFileDescription
            {
                FirstLineHasColumnNames = true,
                IgnoreUnknownColumns = true,
                SeparatorChar = ',',
                UseFieldIndexForReadingData = false,
            };
            var csvContex = new CsvContext();
            List<Food> FoodList = csvContex.Read<Food>(@"C:\Users\utaki\Documents\Code\WaitersApp\WaitersApp\Csv Files\Foods.csv", csvFileDescription).ToList();
            return FoodList;
        }

        public void ShowFoodMenu()
        {
            FoodList.ForEach(food => Console.WriteLine(food));
        }
    }
}
