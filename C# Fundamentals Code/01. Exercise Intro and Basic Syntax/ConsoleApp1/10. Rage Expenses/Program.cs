using System;

namespace _10._Rage_Expenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lostGamesCount = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());
            int headsetCount = 0;
            int mouseCount = 0;
            int keyCount = 0;
            int displCount = 0;

            for (int i = 1; i <= lostGamesCount; i++) // counter na igrite
            {
                bool head = false;
                bool mouse = false;

                if (i % 2 == 0)
                {
                    headsetCount++;
                    head = true;
                }
                if (i % 3 == 0)
                {
                    mouseCount++;
                    mouse = true;
                }
                if (head && mouse)
                {
                    keyCount++;
                    if (keyCount % 2 == 0)
                    {
                        displCount++;
                    }
                }
            }
            double rageExp = headsetCount * headsetPrice + mouseCount * mousePrice + keyCount * keyboardPrice + displCount * displayPrice;
            Console.WriteLine($"Rage expenses: {rageExp:F2} lv.");

        }
    }
}
