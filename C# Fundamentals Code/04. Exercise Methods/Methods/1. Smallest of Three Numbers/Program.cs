using System;

namespace _1._Smallest_of_Three_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int result = SmallestNum(num1, num2);
            int realRes = SmallestNum1(result, num3);
            Console.WriteLine(realRes);
        }

        private static int SmallestNum(int num1, int num2)
        {
            return num1 <= num2 ? num1 : num2;
        }

        static int SmallestNum1(int first, int second)
        {
            return first <= second ? first : second;
        }
    }
}
/*
1-ва зад., 2-ри начин:
 static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            PrintSmallestNumber(a, b, c);
        }

        public static void PrintSmallestNumber(int a, int b, int c)
        {
            int smallestNumber = 0;

            if (a <= b && a <= c)
            {
                smallestNumber = a;
            }
            else if (b <= a && b <= c)
            {
                smallestNumber = b;
            }
            else
            {
                smallestNumber = c;
            }

            Console.WriteLine(smallestNumber);
        }
 */