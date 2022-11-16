using System;

namespace _3._Characters_in_Range
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char start = char.Parse(Console.ReadLine());
            char end = char.Parse(Console.ReadLine());
            PrintCharBetween(start, end);
        }
        private static void PrintCharBetween(char start, char end) // трябва да е войд, а не стринг
        {
            string bukvi = string.Empty;
            if (start < end)
            {
                for (char i = (char)(start + 1); i < end; i++)
                {
                    bukvi += $"{i} ";
                }
            }
            else
            {
                for (char i = (char)(end + 1); i < start; i++)
                {
                    bukvi += $"{i} ";
                }
            }
            Console.WriteLine(bukvi.TrimEnd());
        }
    }
}