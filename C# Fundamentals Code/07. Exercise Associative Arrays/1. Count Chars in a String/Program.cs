using System;
using System.Collections.Generic;

namespace _1._Count_Chars_in_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> counts = new Dictionary<char, int>();

            string input = Console.ReadLine();

            foreach (char sym in input)
            {
                if (sym == ' ')
                {
                    continue;
                }

                if (!counts.ContainsKey(sym))
                {
                    counts.Add(sym, 0);
                }
                counts[sym]++;
            }

            foreach (var sym in counts)
            {
                Console.WriteLine($"{sym.Key} -> {sym.Value}");
            }
        }
    }
}
