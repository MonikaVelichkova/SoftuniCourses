using System;

namespace _4._Print_and_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int sum = 0;
            string space = string.Empty;

            for (int i = num1; i <= num2; i++)
            {

                space += i + " ";
                sum += i;

            }

            Console.WriteLine(space);
            Console.WriteLine($"Sum: {sum}");

        }
    }
}
