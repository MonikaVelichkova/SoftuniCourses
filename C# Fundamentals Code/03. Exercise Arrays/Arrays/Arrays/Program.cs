using System;
using System.Linq;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine()); // the size of the field
            int[] ladyBugs = new int[fieldSize]; // array za leiditata kato size gore 
            int[] initialIndexes = Console.ReadLine()
                                          .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                                          .Select(int.Parse)
                                          .ToArray(); // indexite

            for (int i = 0; i < ladyBugs.Length; i++) // Fill bugs on field
            {
                if (initialIndexes.Contains(i))
                {
                    ladyBugs[i] = 1;
                }
            }
            //------------------------------------------------------------------------------------------

            string[] command = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            while (command[0].ToLower() != "end")
            {
                int index = int.Parse(command[0]);

                if (index < 0 || index >= ladyBugs.Length)   // If index is inside the field
                {
                    command = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                    continue;
                }

                if (ladyBugs[index] == 0)   // cell is empty (NO Lady Bug)
                {
                    command = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                    continue;
                }

                //------------- Fly like the wind -------------
                string direction = command[1];
                int flyLength = int.Parse(command[2]);
                if (flyLength < 0)  // If flyLength is negative, change direction, and make it positive
                {
                    flyLength = Math.Abs(flyLength);
                    switch (direction)
                    {
                        case "right":
                            direction = "left";
                            break;
                        case "left":
                            direction = "right";
                            break;
                    }
                }

                ladyBugs[index] = 0; // Lift off in 3...2...1
                bool isBugFlying = true;
                while (isBugFlying)
                {
                    switch (direction)
                    {
                        case "right":
                            if (index + flyLength >= ladyBugs.Length) // Lady Bug flew away (outside field)
                            {
                                isBugFlying = false;
                            }
                            else
                            {
                                if (ladyBugs[index + flyLength] == 0) //  is cell empty (no Lady Bug at index)
                                {
                                    ladyBugs[index + flyLength] = 1; // Lady Bug landed
                                    isBugFlying = false;
                                }
                                else
                                {
                                    isBugFlying = true; // Lady Bug continues to fly
                                    index += flyLength;
                                }
                            }
                            break;

                        case "left":
                            if (index - flyLength < 0) // Lady Bug flew away (outside field)
                            {
                                isBugFlying = false;
                            }
                            else
                            {
                                if (ladyBugs[index - flyLength] == 0) //  is cell empty (no Lady Bug at index)
                                {
                                    ladyBugs[index - flyLength] = 1; // Lady Bug landed
                                    isBugFlying = false;
                                }
                                else
                                {
                                    isBugFlying = true; // Lady Bug continues to fly
                                    index -= flyLength;
                                }
                            }
                            break;
                    }
                }

                command = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            }

            Console.WriteLine(String.Join(" ", ladyBugs));

        }
    }
}

/*

8)
int[] arr = Console.ReadLine()
                                .Split()
                                .Select(int.Parse)
                                .ToArray(); // арейче

            int n = int.Parse(Console.ReadLine()); // ч-лото 

            for (int i = 0; i < arr.Length; i++)
            {
                for (int k = i + 1; k < arr.Length; k++)
                {
                    if (arr[i] + arr[k] == n)
                    {
                        string sequence = string.Empty;

                        sequence += $"{arr[i]} {arr[k]}";

                        Console.WriteLine(sequence.TrimEnd());
                    }
                }
            }
9)
using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int seqLength = int.Parse(Console.ReadLine()); // purvi input na length
            string command = Console.ReadLine(); // vakrvame commanda
            int[] dNA = new int[seqLength]; // array za dna koito da e s dulj seqLen.

            int dNASum = 0; // suma ako se naloji
            int dNACount = -1; // pochvame ot -1 shtoto drugoto moje da e 0-la i trqbwa da 
            //vleze vse pak
            int dNAStartIndex = -1; // sushtata prichina kato gore
            int dNAfinalPrint = 0; // name checks out :>
            int sample = 0; // nomera na sample-a nakraq za print

            //If there are several sequences with the same length of the subsequence 
            //of ones, print the one with the leftmost starting index, if there are several 
            //sequences with the same length and starting index, select the sequence with 
            //the greater sum of its elements.

            //Find the best DNA !sequence! to use in the production.
            while (command != "Clone them!") // name checks out again :3
            {
                sample++;
                int[] currDNA = command.Split("!", StringSplitOptions.RemoveEmptyEntries)
                                    .Select(int.Parse)
                                    .ToArray(); // cheteneto na current array s ! razdelitel
                int currCount = 0; 
                int currStartIndex = 0;
                int currEndIndex = 0;
                int currDNASum = 0;
                bool isCurrDNABetter = false;
                int count = 0; // tezi sa qsni mislq

                for (int i = 0; i < currDNA.Length; i++) // vurtim v samiq cikul
                {
                    if (currDNA[i] != 1) // ako ne e edno produljavame napred
                    {
                        count = 0;
                        continue;
                    }
                    count++; // tuka znachi e edno => vdigame count za sravnenie

                    if (count > currCount) // ako tozi count e > ot standartniq =>
                    {
                        currCount = count; // zamestvame standartniq
                        currEndIndex = i; // imame nov end index (?)
                    }
                }
                currStartIndex = currEndIndex - currCount + 1; // ?

                currDNASum = currDNA.Sum(); // sumata na dna-to deto e sega

                if (currCount > dNACount)
                {
                    isCurrDNABetter = true;
                }
                else if (currCount == dNACount)
                {
                    if (currStartIndex < dNAStartIndex) // zashtoto ni trqbva tova po ot lqvo
                    {
                        isCurrDNABetter = true;
                    } else if (currStartIndex == dNAStartIndex) // ravni sa...emii
                    {
                        if (currDNASum > dNASum) // gledami sumiti
                        {
                            isCurrDNABetter = true;
                        }
                    }
                }
                if (isCurrDNABetter) // zamestvaneto ako e tru
                {
                    dNA = currDNA;
                    dNACount = currCount;
                    dNAStartIndex = currStartIndex;
                    dNASum = currDNASum;
                    dNAfinalPrint = sample;
                }
                command = Console.ReadLine(); // vse zabravqm, pak se chete nakraq na while!!!
            }
            Console.WriteLine($"Best DNA sample {dNAfinalPrint} with sum: {dNASum}.");
            Console.WriteLine(String.Join(" ", dNA)); // izpisvame bez !
            //kato 6-ta zadacha malko...oburkvashta i gadna xd
        }
    }
}

10)
int fieldSize = int.Parse(Console.ReadLine()); // the size of the field
            int[] ladyBugs = new int[fieldSize]; // array za leiditata kato size gore 
            int[] initialIndexes = Console.ReadLine()
                                          .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                                          .Select(int.Parse)
                                          .ToArray(); // indexite

            for (int i = 0; i < ladyBugs.Length; i++) // Fill bugs on field
            {
                if (initialIndexes.Contains(i))
                {
                    ladyBugs[i] = 1;
                }
            }
            //------------------------------------------------------------------------------------------

            string[] command = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            while (command[0].ToLower() != "end")
            {
                int index = int.Parse(command[0]);

                if (index < 0 || index >= ladyBugs.Length)   // If index is inside the field
                {
                    command = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                    continue;
                }

                if (ladyBugs[index] == 0)   // cell is empty (NO Lady Bug)
                {
                    command = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                    continue;
                }

                //------------- Fly like the wind -------------
                string direction = command[1];
                int flyLength = int.Parse(command[2]);
                if (flyLength < 0)  // If flyLength is negative, change direction, and make it positive
                {
                    flyLength = Math.Abs(flyLength);
                    switch (direction)
                    {
                        case "right":
                            direction = "left";
                            break;
                        case "left":
                            direction = "right";
                            break;
                    }
                }

                ladyBugs[index] = 0; // Lift off in 3...2...1
                bool isBugFlying = true;
                while (isBugFlying)
                {
                    switch (direction)
                    {
                        case "right":
                            if (index + flyLength >= ladyBugs.Length) // Lady Bug flew away (outside field)
                            {
                                isBugFlying = false;
                            }
                            else
                            {
                                if (ladyBugs[index + flyLength] == 0) //  is cell empty (no Lady Bug at index)
                                {
                                    ladyBugs[index + flyLength] = 1; // Lady Bug landed
                                    isBugFlying = false;
                                }
                                else
                                {
                                    isBugFlying = true; // Lady Bug continues to fly
                                    index += flyLength;
                                }
                            }
                            break;

                        case "left":
                            if (index - flyLength < 0) // Lady Bug flew away (outside field)
                            {
                                isBugFlying = false;
                            }
                            else
                            {
                                if (ladyBugs[index - flyLength] == 0) //  is cell empty (no Lady Bug at index)
                                {
                                    ladyBugs[index - flyLength] = 1; // Lady Bug landed
                                    isBugFlying = false;
                                }
                                else
                                {
                                    isBugFlying = true; // Lady Bug continues to fly
                                    index -= flyLength;
                                }
                            }
                            break;
                    }
                }

                command = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            }

            Console.WriteLine(String.Join(" ", ladyBugs));

 */