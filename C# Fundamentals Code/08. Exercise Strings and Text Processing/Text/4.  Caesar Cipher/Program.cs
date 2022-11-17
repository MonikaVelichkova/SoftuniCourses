using System;

namespace _4.__Caesar_Cipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string encrypted = string.Empty;

            foreach (char symbol in input)
            {
                encrypted += (char)(symbol + 3);
            }

            Console.WriteLine(encrypted);
        }
    }
}
