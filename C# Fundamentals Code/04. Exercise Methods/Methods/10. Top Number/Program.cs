using System;

namespace _10._Top_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            TopNum(number);
        }
        private static void TopNum(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                int sum = 0;
                bool odd = false;

                foreach (char symbol in i.ToString()) //pravim chisloto to vurteneto i na char symb
                {
                    int cifra = symbol - '0';
                    sum += cifra; // sum of digits is divisible by 8? proverka
                    if (cifra % 2 != 0)
                    {
                        odd = true;
                    }
                }
                if (sum % 8 == 0 && odd)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}