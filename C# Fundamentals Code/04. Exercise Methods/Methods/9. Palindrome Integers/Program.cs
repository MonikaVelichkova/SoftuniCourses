using System;

namespace _9._Palindrome_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            while (input != "END") // върти докато не дадем енд
            {
                int number = int.Parse(input); // прави стринга в число
                PalindromeIntegers(number); // функцийката или метода баам
                input = Console.ReadLine(); // повторка
            }
        }
        private static void PalindromeIntegers(int num)
        {
            char[] numbersText = num.ToString().ToCharArray();
            Array.Reverse(numbersText); // отзад напред подреждаме
            int number = int.Parse(new string(numbersText)); // правим обърнатото в цифра от чар

            Console.WriteLine(num == number ? "true" : "false"); // проверка дали са равни ч-лата
        }
    }
}