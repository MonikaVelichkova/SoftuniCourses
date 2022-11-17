using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _1._Furniture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> furnitureBought = new List<string>();
            decimal totalMonSpend = 0m;

            string pattern = @"[>]{2}(?<name>[A-Za-z]+)[<]{2}(?<price>\d+(\.\d+)?)\!(?<quantity>\d+)";

            string input = Console.ReadLine();

            while (input != "Purchase")
            {
                Match furnitureInfo = Regex.Match(input, pattern);
                if (furnitureInfo.Success)
                {
                    string furnitureName = furnitureInfo.Groups["name"].Value;
                    decimal price = decimal.Parse(furnitureInfo.Groups["price"].Value);
                    int qty = int.Parse(furnitureInfo.Groups["quantity"].Value);

                    furnitureBought.Add(furnitureName);
                    totalMonSpend += price * qty;

                }
                input = Console.ReadLine();
            }

            Console.WriteLine("Bought furniture:");

            foreach (string furnName in furnitureBought)
            {
                Console.WriteLine(furnName);
            }

            Console.WriteLine($"Total money spend: {totalMonSpend:f2}");
        }
    }
}
