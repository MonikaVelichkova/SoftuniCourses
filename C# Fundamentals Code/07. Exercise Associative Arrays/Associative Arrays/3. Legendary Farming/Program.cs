using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Legendary_Farming
{
    internal class Program
    {           
            static void Main(string[] args)
            {
                Dictionary<string, int> materials = new Dictionary<string, int>()
        {
            { "shards", 0 },
            { "fragments", 0 },
            { "motes", 0 }
        };
                Dictionary<string, int> junks = new Dictionary<string, int>();

                bool isItemObtainable = false;
                while (!isItemObtainable)
                {
                    string[] input = Console.ReadLine().Split();
                    int quantity = 0;

                    for (int i = 0; i < input.Length; i++)
                    {
                        if (i % 2 != 0)
                        {
                            string resource = input[i].ToLower();
                            if (materials.ContainsKey(resource))
                            {
                                materials[resource] += quantity;
                                if (materials[resource] >= 250)
                                {
                                    isItemObtainable = true;
                                    break;
                                }
                            }
                            else
                            {
                                if (!junks.ContainsKey(resource))
                                {
                                    junks.Add(resource, 0);
                                }
                                junks[resource] += quantity;
                            }

                        }
                        else
                        {
                            quantity = int.Parse(input[i]);
                        }
                    }
                }
                KeyValuePair<string, int> kvp = materials.FirstOrDefault(ValueTuple => ValueTuple.Value >= 250);
                materials[kvp.Key] -= 250;
                string item = string.Empty;

                switch (kvp.Key)
                {
                    case "shards":
                        item = "Shadowmourne";
                        break;

                    case "fragments":
                        item = "Valanyr";
                        break;

                    case "motes":
                        item = "Dragonwrath";
                        break;
                }
                Console.WriteLine($"{item} obtained!");

                //foreach(var material in materials.OrderByDescending(m=> m.Value).ThenBy(m => m.Key))
                foreach (var material in materials.OrderByDescending(m => m.Key).ThenBy(m => m.Value))
                // foreach(var material in materials.OrderBy(m => m.Key).ThenByDescending(m=> m.Value)
                // OrderByDescending(m=> m.Value).ThenBy(m => m.Key))
                {
                    Console.WriteLine($"{material.Key}: {material.Value}");
                }

                foreach (var junk in junks.OrderByDescending(j => j.Key).ThenBy(j => j.Value))
                {
                    Console.WriteLine($"{junk.Key}: {junk.Value}");
                }

            }
        
    }
}
