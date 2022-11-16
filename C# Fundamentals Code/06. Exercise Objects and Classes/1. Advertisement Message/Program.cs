using System;

namespace _1._Advertisement_Message
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] phrase = new string[] {"Excellent product.", "Such a great product.",
                                    "I always use that product.",
                                    "Best product of its category.",
                                    "Exceptional product.",
                                    "I can’t live without this product."
            };

            string[] eventt = new string[] { "Now I feel good.", "I have succeeded with this product.",
                                    "Makes miracles. I am happy of the results!",
                                    "I cannot believe but now I feel awesome.",
                                    "Try it yourself, I am very satisfied.",
                                    "I feel great!"
            };

            string[] autor = new string[] { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };

            string[] city = new string[] { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            int num = int.Parse(Console.ReadLine());
            string message = string.Empty;

            while (num > 0)
            {
                message += GetRandomMessage(phrase) + " ";
                message += GetRandomMessage(eventt) + " ";
                message += GetRandomMessage(autor) + " ";
                message += GetRandomMessage(city) + " ";

                Console.WriteLine(message);
                message = string.Empty;
                num--;
            }
        }
        public static string GetRandomMessage(string[] dataArray)
        {
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, dataArray.Length - 1);
            return dataArray[randomIndex];
        }
    }
}
