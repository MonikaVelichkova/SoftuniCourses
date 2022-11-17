using System;
using System.Text.RegularExpressions;

namespace _3._SoftUni_Bar_Income
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal totalMonSpend = 0m;
            string pattern =
            @"\%(?<client>[A-Z]{1}[a-z]+)\%[^%$|.]*?\<(?<product>\w+)\>[^%$|.]*?\|(?<count>\d+)\|[^%$|.]*?(?<price>\d+(\.\d+)?)\$";

            string input = Console.ReadLine();

            while (input != "end of shift")
            {
                Match match = Regex.Match(input, pattern);

                if (match.Success)
                {
                    string client = match.Groups["client"].Value;
                    string product = match.Groups["product"].Value;
                    int count = int.Parse(match.Groups["count"].Value);
                    decimal price = decimal.Parse(match.Groups["price"].Value);

                    decimal totalPrice = count * price;
                    totalMonSpend += totalPrice;

                    Console.WriteLine($"{client}: {product} - {totalPrice:f2}");
                }

                input = Console.ReadLine();
            }
            Console.WriteLine($"Total income: {totalMonSpend:f2}");
        }
    }
}
