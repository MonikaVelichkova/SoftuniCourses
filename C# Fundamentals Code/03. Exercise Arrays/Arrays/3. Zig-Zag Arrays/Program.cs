using System;
using System.Linq;

namespace _3._Zig_Zag_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] arr1 = new int[n];
            int[] arr2 = new int[n];

            for (int i = 1; i <= n; i++)
            {
                int[] currRowData = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToArray();

                int firstNum = currRowData[0];
                int secNum = currRowData[1];

                if (i % 2 != 0)
                {
                    arr1[i - 1] = firstNum;
                    arr2[i - 1] = secNum;

                }
                else
                {
                    arr1[i - 1] = secNum;
                    arr2[i - 1] = firstNum;

                }
            }
            Console.WriteLine(String.Join(" ", arr1));
            Console.WriteLine(String.Join(" ", arr2));
        }
    }
}
