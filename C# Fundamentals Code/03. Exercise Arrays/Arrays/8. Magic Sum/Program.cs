using System;
using System.Linq;

namespace _8._Magic_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                                .Split()
                                .Select(int.Parse)
                                .ToArray();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < arr.Length; i++)
            {
                for (int k = i + 1; k < arr.Length; k++)
                {
                    if (arr[i] + arr[k] == n)
                    {
                        string sequence = string.Empty;

                        sequence += $"{arr[i]} {arr[k]}";

                        Console.WriteLine(sequence.TrimEnd());
                    }
                }
            }
        }
    }
}
