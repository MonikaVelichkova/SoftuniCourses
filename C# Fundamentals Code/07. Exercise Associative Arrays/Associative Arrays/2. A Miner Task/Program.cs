using System;
using System.Collections.Generic;

namespace _2._A_Miner_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> resursi = new Dictionary<string, int>();
            string input = Console.ReadLine();
            string currResurs = string.Empty;
            int broii = 1;

            while (input != "stop")
            {
                if (broii % 2 != 0)
                {
                    currResurs = input;
                    if (!resursi.ContainsKey(currResurs))
                    {
                        resursi.Add(currResurs, 0);
                    }
                }
                else
                {
                    resursi[currResurs] += int.Parse(input);
                }
                broii++;
                input = Console.ReadLine();
            }
            foreach (var r in resursi)
            {
                Console.WriteLine($"{r.Key} -> {r.Value}");
            }
        }
    }
}
