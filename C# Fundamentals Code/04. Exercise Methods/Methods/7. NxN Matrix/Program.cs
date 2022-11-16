using System;

namespace _7._NxN_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            PrintMatrix(input);
        }
        private static void PrintMatrix(int input)
        {
            int num = input;
            for (int i = 0; i < input; i++)
            {
                for (int k = 0; k < input; k++)
                {
                    Console.Write($"{num} ");
                }
                Console.WriteLine();
            }
        }
    }
}