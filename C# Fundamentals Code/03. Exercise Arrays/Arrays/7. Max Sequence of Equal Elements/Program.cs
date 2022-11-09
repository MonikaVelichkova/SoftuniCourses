using System;
using System.Linq;

namespace _7._Max_Sequence_of_Equal_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                                .Split()
                                .Select(int.Parse)
                                .ToArray();

            int bestNum = arr.Last(); 
            int bestCount = 1;

            int currNum = arr.Last(); 
            int currCount = 1;

            for (int i = arr.Length - 1; i > 0; i--) 
                                                      
                                                     
            {
                if (arr[i] != arr[i - 1]) 
                {
                    currNum = arr[i - 1];
                    currCount = 1;
                    continue; 
                }

                currCount++; 

                if (currCount >= bestCount)
                {
                    bestCount = currCount;
                    bestNum = currNum;
                }
            }

            string sequence = string.Empty;
            for (int i = 0; i < bestCount; i++)
            {
                sequence += $"{bestNum} ";
            }

            Console.WriteLine(sequence.TrimEnd());
        }
    }
}
