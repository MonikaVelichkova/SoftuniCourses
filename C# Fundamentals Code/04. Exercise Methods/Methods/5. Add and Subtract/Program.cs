using System;

namespace _5._Add_and_Subtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int num12Sum = SumFirstTwo(num1, num2);
            int minusThird = MinusThird(num12Sum, num3);
            Console.WriteLine(minusThird);
        }
        private static int SumFirstTwo(int num1, int num2)
        {
            return num1 + num2;
        }
        private static int MinusThird(int num12Sum, int num3)
        {
            return num12Sum - num3;
        }
    }
}