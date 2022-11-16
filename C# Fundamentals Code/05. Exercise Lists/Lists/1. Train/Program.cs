using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> listWagons = Console.ReadLine().Split().Select(int.Parse).ToList();
            
            int maxCapOfSingleWagon = int.Parse(Console.ReadLine());
            //name checks out

            string[] command = Console.ReadLine().Split();
            //command pod forma na array string za po easy check ;)

            while (command[0] != "end")
            {
                if (command[0] == "Add")
                {
                    listWagons.Add(int.Parse(command[1]));
                }
                else
                {
                    for (int i = 0; i < listWagons.Count; i++)
                    {
                        if (maxCapOfSingleWagon - listWagons[i] >= int.Parse(command[0]))
                        {
                            listWagons[i] += int.Parse(command[0]);
                            break;
                        }
                    }
                }
                command = Console.ReadLine().Split();
            }
            Console.WriteLine(string.Join(" ", listWagons));
        }
    }
}

/*
(7)

static void Main(string[] args)
        {
           
        }

 */