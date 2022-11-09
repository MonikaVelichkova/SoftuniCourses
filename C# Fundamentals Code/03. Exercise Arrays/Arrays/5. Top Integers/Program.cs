using System;
using System.Linq;

namespace _5._Top_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToArray();
            string compare = string.Empty;

            for (int i = 0; i < arr.Length; i++)
            {
                bool isBigger = true;
                for (int k = i + 1; k < arr.Length; k++)
                {
                    if (arr[i] <= arr[k])
                    {
                        isBigger = false;
                        break;
                    }
                }

                if (isBigger)
                {
                    compare += arr[i] + " ";
                }

            }
            Console.WriteLine(compare.TrimEnd());
        }
    }
}
