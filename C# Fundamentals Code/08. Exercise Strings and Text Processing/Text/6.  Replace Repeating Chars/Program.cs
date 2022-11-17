using System;

namespace _6.__Replace_Repeating_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string replace = string.Empty;
            replace += input[0];

            for (int i = 0; i < input.Length - 1; i++)
            {
                if (input[i] != input[i + 1])
                {
                    replace += input[i + 1];
                }
            }

            Console.WriteLine(replace);
        }
    }
}
