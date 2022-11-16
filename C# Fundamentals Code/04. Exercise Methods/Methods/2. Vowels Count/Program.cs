using System;
using System.Linq;

namespace _2._Vowels_Count
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            string input = Console.ReadLine();
            Vowel(input);            
                        
        }
        private static void Vowel(string input) // трябва да е войд, а не стринг
        {
            int count = 0;
            char[] vowl = new char[] { 'A', 'a', 'E', 'e', 'I', 'i', 'O', 'o', 'U', 'u' };

            foreach (char symb in input) // обикаляме инпута като дума
            {
                if (vowl.Contains(symb)) // сравнявн буквите с др гласни от масива
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}
