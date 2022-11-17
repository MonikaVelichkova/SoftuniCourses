using System;
using System.Text;

namespace _7.__String_Explosion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            StringBuilder outputText = new StringBuilder();
            int bombPow = 0;

            for (int i = 0; i < input.Length; i++)
            {
                char currCh = input[i];

                if (currCh == '>')
                {
                    int currBombPow = GetIntValue(input[i + 1]);
                    outputText.Append(currCh);
                    bombPow += currBombPow;
                }
                else
                {
                    if (bombPow > 0)
                    {                        
                        bombPow--;
                    }
                    else
                    {
                        outputText.Append(currCh);
                    }
                }
            }

            Console.WriteLine(outputText.ToString());
        }
        static int GetIntValue(char ch)
        {
            return (int)ch - 48;
            // ot ASCi table
        }
    }
}
