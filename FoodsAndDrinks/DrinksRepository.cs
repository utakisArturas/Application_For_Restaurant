using LINQtoCSV;
using System;
using System.Collections.Generic;
using System.Linq;


namespace WaitersApp
{
    public class DrinksRepository :Drink
    {
        public List<Drink> DrinkList = ReadDrinkCsvService();

        public static List<Drink> ReadDrinkCsvService()
        {
            var csvFileDescription = new CsvFileDescription
            {
                FirstLineHasColumnNames = true,
                IgnoreUnknownColumns = true,
                SeparatorChar = ',',
                UseFieldIndexForReadingData = false,
            };
            var csvContex = new CsvContext();
            List<Drink> FoodList = csvContex.Read<Drink>(@"C:\Users\utaki\Documents\Code\WaitersApp\WaitersApp\Csv Files\Drinks.csv", csvFileDescription).ToList();
            return FoodList;
        }

        public void ShowDrinksMenu()
        {
            DrinkList.ForEach(drink => Console.WriteLine(drink));
        }
    }
}
