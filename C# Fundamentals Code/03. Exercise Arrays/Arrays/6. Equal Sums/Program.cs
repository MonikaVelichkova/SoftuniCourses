using System;
using System.Linq;

namespace _6._Equal_Sums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToArray();

            if (arr.Length == 1)
            {
                Console.WriteLine(0);
                return;
            }

            int index = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                int sum1 = 0;
                int sum2 = 0;

                for (int left = i - 1; left >= 0; left--)
                {
                    sum1 += arr[left];
                }

                for (int right = i + 1; right < arr.Length; right++)
                {
                    sum2 += arr[right];
                }

                if (sum1 == sum2)
                {
                    Console.WriteLine(i);
                    return;
                }

            }
            Console.WriteLine("no");
        }
    }
}
