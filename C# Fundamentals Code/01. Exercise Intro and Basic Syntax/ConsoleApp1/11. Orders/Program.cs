using System;

namespace _11._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double total = 0;

            for (int i = 1; i <= n; i++)
            {
                double priceCapsule = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                int capsCount = int.Parse(Console.ReadLine());

                double orderPrice = (days * capsCount) * priceCapsule;
                total += orderPrice;
                Console.WriteLine($"The price for the coffee is: ${orderPrice:F2}");
            }
            Console.WriteLine($"Total: ${total:F2}");

        }
    }
}
