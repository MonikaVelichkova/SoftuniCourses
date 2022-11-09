using System;

namespace _5._Print_Part_of_the_ASCII_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nachalo = int.Parse(Console.ReadLine());
            int krai = int.Parse(Console.ReadLine());

            string output = string.Empty;

            for (int i = nachalo; i <= krai; i++)
            {
                output += (char)i + " ";
            }

            Console.WriteLine(output);
        }
    }
}
