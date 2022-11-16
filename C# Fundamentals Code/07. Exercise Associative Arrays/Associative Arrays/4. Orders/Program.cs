using System;
using System.Collections.Generic;

namespace _4._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Tuple<decimal, int>> produktiDict
                = new Dictionary<string, Tuple<decimal, int>>();

            string[] productInfoo = Console.ReadLine().Split();

            while (productInfoo[0] != "buy")
            {
                string product = productInfoo[0];
                decimal price = decimal.Parse(productInfoo[1]);
                int quantity = int.Parse(productInfoo[2]);

                if (!produktiDict.ContainsKey(product))
                {
                    produktiDict.Add(product, new Tuple<decimal, int>(price, quantity));
                }
                else
                {
                    int oldQuant = produktiDict[product].Item2;

                    produktiDict[product]
                        = new Tuple<decimal, int>(price, oldQuant + quantity);
                }

                productInfoo = Console.ReadLine().Split();
            }

            foreach (var product in produktiDict)
            {
                Console.WriteLine($"{product.Key} -> {product.Value.Item1 * product.Value.Item2:F2}");
            }
        }
    }
}
