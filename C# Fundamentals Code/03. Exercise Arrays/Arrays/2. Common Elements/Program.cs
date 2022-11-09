using System;
using System.Linq;

namespace _2._Common_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arr1 = Console.ReadLine().Split(); // array 1
            string[] arr2 = Console.ReadLine().Split(); // array 2
            string compare = string.Empty; 
                                           
            for (int i = 0; i < arr2.Length; i++)
            {                                  
                if (arr1.Contains(arr2[i]))
                {
                    compare += arr2[i] + " ";
                }
            }
            Console.WriteLine(compare.TrimEnd());

        }
    }
}
