using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Change_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> listInt = Console.ReadLine().Split().Select(int.Parse).ToList();
            //chetene na lista
            string[] command = Console.ReadLine().Split();

            while (command[0] != "end")
            {
                if (command[0] == "Delete")
                {
                    listInt.RemoveAll(n => n == int.Parse(command[1]));
                }
                else if (command[0] == "Insert")
                {
                    int posit = int.Parse(command[2]);
                    int elem = int.Parse(command[1]);

                    listInt.Insert(posit, elem);
                }
                command = Console.ReadLine().Split();
            }
            Console.WriteLine(string.Join(" ", listInt));
        }
    }
}
