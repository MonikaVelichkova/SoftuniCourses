using System;
using System.Linq;
using System.Numerics;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numSnowballs = int.Parse(Console.ReadLine()); // da

            int bestSnowballSnow = 0;
            int bestSnowballTime = 0;
            int bestSnowballQuality = 0;
            BigInteger bestSnowballValue = 0;

            for (int i = 1; i <= numSnowballs; i++) // for cikul da
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine()); // da na 3te

                BigInteger snowballValue = BigInteger.Pow((snowballSnow / snowballTime), snowballQuality);                

                if (snowballValue >= bestSnowballValue)
                {
                    bestSnowballSnow = snowballSnow;
                    bestSnowballTime = snowballTime;
                    bestSnowballQuality = snowballQuality;
                    bestSnowballValue = snowballValue;
                }
            }

            Console.WriteLine($"{bestSnowballSnow} : {bestSnowballTime} = {bestSnowballValue} ({bestSnowballQuality})");
        }
    }
}



/*
9)
int num = int.Parse(Console.ReadLine());
            int numZaPromqna = num;
            int sum = 0;
            int count = 0;
            
            while(numZaPromqna >= 100) // vurti se dokato ne stane po malko ot 100
            {
                sum += (numZaPromqna - 26); // 
                numZaPromqna -= 10; // 
                count++; 
            }            
            if(sum - 26 >= 0) // za da ne stava otricatelno?
            {
                sum -= 26;
            }
            Console.WriteLine(count);
            Console.WriteLine(sum);

10)
int count = 0;
            int n = int.Parse(Console.ReadLine()); // power of pokemon
            int m = int.Parse(Console.ReadLine()); // distance
            int y = int.Parse(Console.ReadLine()); // exastion factor
            int originValueofN = n;
            // N = 5, M = 2, Y = 3 vuvedeni

            while (m <= n) // pravim tova dokato m e po mal ot n
            {
                n -= m; // vadeneto n - m + sega proverka dali e bash 50%
                count++; // pokey~ pokeyy~~
                if ( n + (originValueofN * 0.5) == originValueofN && y != 0) // prim. 5 sled izvajd + 10*0.5=?10, tuka da
                {
                    n /= y; // delenieto ako e tru => primerno izlizame ot while-a
                }
            }
            Console.WriteLine(n);
            Console.WriteLine(count);

11)
int numSnowballs = int.Parse(Console.ReadLine()); // da

            int bestSnowballSnow = 0;
            int bestSnowballTime = 0;
            int bestSnowballQuality = 0;
            BigInteger bestSnowballValue = 0;

            for (int i = 1; i <= numSnowballs; i++) // for cikul da
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine()); // da na 3te

                BigInteger snowballValue = BigInteger.Pow((snowballSnow / snowballTime), snowballQuality);                

                if (snowballValue >= bestSnowballValue)
                {
                    bestSnowballSnow = snowballSnow;
                    bestSnowballTime = snowballTime;
                    bestSnowballQuality = snowballQuality;
                    bestSnowballValue = snowballValue;
                }
            }

            Console.WriteLine($"{bestSnowballSnow} : {bestSnowballTime} = {bestSnowballValue} ({bestSnowballQuality})");

12)?arrays?
int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            // първи арей, който се чете
            int firstLength = array.Length;
            // дължината му

            for (int i = 0; i < firstLength - 1; i++) // лууп, който ще обикаля арей 1
            {
                int[] condensed = new int[array.Length - 1]; 
                // нов арей, който взима дълж. на първия

                for (int j = 0; j < array.Length - 1; j++) // пак обикаляне
                {
                    condensed[j] = array[j] + array[j + 1]; // това ще се прави при 
                    //всяко завъртане => първо ще е [0] + [1] и ще отиде в нулата 
                    //на конденсд, после ще е [1] + [2] и ще отиде в [1] на конд. и т.н.
                }

                array = condensed; // това го разбирам тбх щото те ще се събират и всеки
                //път намалят с едно самите [ ], тоест събиранията се правят всеки път със
                //всичките и те всеки път намалят и накрая ще остане само един елемент

            }
            Console.WriteLine(array[0]);
*/
