using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _2._Race
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dictRacers = new Dictionary<string, int>();

            string[] participants = Console.ReadLine()
                                    .Split(", ")
                                    .ToArray();
            for (int i = 0; i < participants.Length; i++)
            {
                if (!dictRacers.ContainsKey(participants[i]))
                {
                    dictRacers.Add(participants[i], 0);
                }
            }

            string namePattern = @"[A-Za-z]+";
            string distPattern = @"\d";

            string input = Console.ReadLine();

            while (input != "end of race")
            {
                string name = String.Join("", Regex.Matches(input, namePattern));

                MatchCollection dist = Regex.Matches(input, distPattern);
                int maxDist = dist.Sum(x => int.Parse(x.Value));

                if (dictRacers.ContainsKey(name))
                {
                    dictRacers[name] += maxDist;
                }

                input = Console.ReadLine();
            }


            int place = 1;
            string endW = "st";
            foreach (var racer in dictRacers.OrderByDescending(r => r.Value).Take(3))
            {
                if (place == 2)
                {
                    endW = "nd";
                }
                if (place == 3)
                {
                    endW = "rd";
                }


                Console.WriteLine($"{place++}{endW} place: {racer.Key}");
            }
        }
    }
}
