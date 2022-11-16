using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Bomb_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> listInt = Console.ReadLine().Split().Select(int.Parse).ToList();
            //chetene na lista i array za bomb int-ovete
            int[] bombInts = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int bombNum = bombInts[0];
            int bombPow = bombInts[1];

            for (int i = 0; i < bombPow; i++) // цикъл за силата на бомба
            {
                for (int k = 0; k < listInt.Count; k++) // въртим целия лист
                {
                    if (listInt[k] == bombNum) // ако даденото число е бомбата
                    {
                        if (k - 1 >= 0)
                        {
                            listInt.RemoveAt(k - 1);
                            k--;
                        }

                        if (k + 1 < listInt.Count)
                        {
                            listInt.RemoveAt(k + 1);
                        }
                    }
                }
            }

            listInt.RemoveAll(n => n == bombNum);
            Console.WriteLine(listInt.Sum());
        }
    }
}
