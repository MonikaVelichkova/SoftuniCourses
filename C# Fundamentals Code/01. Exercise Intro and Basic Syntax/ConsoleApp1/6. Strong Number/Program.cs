using System;

namespace _6._Strong_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
                int num = int.Parse(Console.ReadLine());
                int sum = 0;
                int numCopy = num;

                while (numCopy != 0)
                {
                    int digit = numCopy % 10;
                    sum = sum + getFactorial(digit);
                    numCopy /= 10;
                }
                if (sum == num)
                {
                    Console.WriteLine("yes");
                }
                else
                {
                    Console.WriteLine("no");
                }         

        }
        static int getFactorial(int number)
        {
            int factorial = 1;
            for (int i = number; i > 1; i--)
            {
                factorial = factorial * i;
            }
            return factorial;
        }
    }
}
