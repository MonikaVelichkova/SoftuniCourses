using System;
using System.Collections.Generic;
using System.Linq;

namespace _4._List_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> listInt = Console.ReadLine().Split().Select(int.Parse).ToList();
            //chetene na lista
            string[] command = Console.ReadLine().Split();

            while (command[0] != "End")
            {
                if (command[0] == "Add")
                {
                    int numAdd = int.Parse(command[1]);
                    listInt.Add(numAdd);
                }
                else if (command[0] == "Insert")
                {
                    int numInsert = int.Parse(command[1]);
                    int posit = int.Parse(command[2]);

                    if (posit < 0 || posit >= listInt.Count)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        listInt.Insert(posit, numInsert);
                    }
                }
                else if (command[0] == "Remove")
                {
                    int numPosit = int.Parse(command[1]);
                    if (numPosit < 0 || numPosit >= listInt.Count)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        listInt.RemoveAt(numPosit);
                    }
                }
                else if (command[0] == "Shift")
                {
                    if (command[1] == "left")
                    {
                        int countL = int.Parse(command[2]);
                        for (int i = 0; i < countL; i++)
                        {
                            listInt.Add(listInt.First());
                            listInt.RemoveAt(0);
                        }
                    }
                    else if (command[1] == "right")
                    {
                        int countR = int.Parse(command[2]);
                        for (int k = 0; k < countR; k++)
                        {
                            listInt.Insert(0, listInt.Last());
                            listInt.RemoveAt(listInt.Count - 1);
                        }
                    }
                }
                command = Console.ReadLine().Split();
            }
            Console.WriteLine(string.Join(" ", listInt));
        }
    }
}
