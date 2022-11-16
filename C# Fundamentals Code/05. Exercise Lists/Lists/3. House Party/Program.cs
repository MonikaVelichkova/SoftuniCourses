using System;
using System.Collections.Generic;

namespace _3._House_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numCom = int.Parse(Console.ReadLine());
            List<string> namesPeople = new List<string>();

            for (int i = 0; i < numCom; i++)
            {   
                string[] command = Console.ReadLine().Split();
                                                              
                string name = command[0];
                if (command[2] == "going!")
                {
                    if (namesPeople.Contains(name))
                    {
                        Console.WriteLine($"{name} is already in the list!");
                    }
                    else
                    {
                        namesPeople.Add(name);
                    }

                }
                else if (command[2] == "not") // not going
                {
                    if (namesPeople.Contains(name))
                    {
                        namesPeople.Remove(name);
                    }
                    else
                    {
                        Console.WriteLine($"{name} is not in the list!");
                    }
                }

            }
            Console.WriteLine(string.Join(Environment.NewLine, namesPeople));
        }
    }
}
