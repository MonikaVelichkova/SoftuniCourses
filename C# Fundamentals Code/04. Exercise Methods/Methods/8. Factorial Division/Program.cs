using System;

namespace _8._Factorial_Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            long fact1 = FactorialDivision(num1);
            long fact2 = FactorialDivision(num2);
            double divis = (double)fact1 / (double)fact2;

            Console.WriteLine($"{divis:F2}");
        }
        private static long FactorialDivision(int num)
        {
            if (num == 1)
            {
                return 1;
            }
            return num * FactorialDivision(num - 1);
        }
    }
}