using System;

namespace _2.__Character_Multiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int sum = 0;
            string firstStr = input[0];
            string secondStr = input[1];

            if (firstStr.Length > secondStr.Length)
            {
                for (int i = 0; i < secondStr.Length; i++)
                {
                    sum += firstStr[i] * secondStr[i];
                }
                for (int i = secondStr.Length; i < firstStr.Length; i++)
                {
                    sum += firstStr[i];
                }
            }
            else if (firstStr.Length < secondStr.Length)
            {
                for (int i = 0; i < firstStr.Length; i++)
                {
                    sum += firstStr[i] * secondStr[i];
                }
                for (int i = firstStr.Length; i < secondStr.Length; i++)
                {
                    sum += secondStr[i];
                }
            }
            else
            {
                for (int i = 0; i < firstStr.Length; i++)
                {
                    sum += firstStr[i] * secondStr[i];
                }
            }
            Console.WriteLine(sum);
        }
    }
}
