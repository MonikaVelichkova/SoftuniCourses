using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _4.__Star_Enigma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<string> attackedPlanets = new List<string>();
            List<string> destroyedPlanets = new List<string>();

            string pattern = @"\@(?<planet>[A-Za-z]+)[^\@\-\!\:\>]*?\:(\d+)[^\@\-\!\:\>]*?\!(?<attackType>A|D){1}\![^\@\-\!\:\>]*?\-\>(\d+)";

            for (int i = 0; i < n; i++)
            {
                string message = Console.ReadLine();
                string decrypted = string.Empty;

                MatchCollection matches = Regex.Matches(message, @"[STARstar]");

                for (int k = 0; k < message.Length; k++)
                {
                    decrypted += (char)(message[k] - matches.Count);
                }

                Match orderInfo = Regex.Match(decrypted, pattern);
                if (orderInfo.Success)
                {
                    string planet = orderInfo.Groups["planet"].Value;
                    string attType = orderInfo.Groups["attackType"].Value;

                    if (attType == "A")
                    {
                        attackedPlanets.Add(planet);
                    }
                    else if (attType == "D")
                    {
                        destroyedPlanets.Add(planet);
                    }
                }

            }
            PrintOutput(attackedPlanets, destroyedPlanets);

        }

        static void PrintOutput(List<string> attackedPl, List<string> destroyedPl)
        {
            Console.WriteLine($"Attacked planets: {attackedPl.Count}");

            foreach (var pl in attackedPl.OrderBy(n => n))
            {
                Console.WriteLine($"-> {pl}");
            }

            Console.WriteLine($"Destroyed planets: {destroyedPl.Count}");

            foreach (var pl in destroyedPl.OrderBy(n => n))
            {
                Console.WriteLine($"-> {pl}");
            }

        }
    }
}
