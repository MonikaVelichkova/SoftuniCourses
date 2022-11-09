using System;

namespace _1._Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numOfPass = new int[n];
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                numOfPass[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{numOfPass[i]} ");
                sum += numOfPass[i];
            }
            Console.WriteLine(Environment.NewLine + sum);
        }
    }
}
