using System;

namespace _6._Triples_of_Latin_Letters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());


            for (char i = 'a'; i < 'a' + number; i++)
            {

                for (char k = 'a'; k < 'a' + number; k++)
                {


                    for (char l = 'a'; l < 'a' + number; l++)
                    {


                        Console.WriteLine($"{i}{k}{l}");
                    }

                }

            }


            int n = int.Parse(Console.ReadLine());
            string output = string.Empty;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    for (int k = 0; k < n; k++)
                    {
                        output += (char)i + (char)j + (char)k;
                    }
                }
            }

            n = int.Parse(Console.ReadLine());

            for (int c1 = 97; c1 < 97 + n; c1++)
            {
                for (int c2 = 97; c2 < 97 + n; c2++)
                {
                    for (int c3 = 97; c3 < 97 + n; c3++)
                    {
                        Console.WriteLine($"{(char)c1}{(char)c2}{(char)c3}");
                    }
                }
            }


        }
    }
}
