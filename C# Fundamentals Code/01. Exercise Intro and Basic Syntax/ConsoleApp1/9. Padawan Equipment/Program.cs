using System;

namespace _9._Padawan_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float moneyHad = float.Parse(Console.ReadLine()); 
            int countStudents = int.Parse(Console.ReadLine());
            float priceLightsabers = float.Parse(Console.ReadLine()); 
            float priceRobes = float.Parse(Console.ReadLine());
            float priceBelts = float.Parse(Console.ReadLine());            

            int countShestici = 0;

            for (int i = 1; i <= countStudents; i++) 
            {
                if (i % 6 == 0)
                {
                    countShestici++; 
                }
            }
            int countStudentsBezShest = countStudents - countShestici;

            float cost = (float)(priceLightsabers * Math.Ceiling(countStudents * 1.1) + priceRobes * countStudents + priceBelts * countStudentsBezShest);

            if (cost <= moneyHad)
            {
                Console.WriteLine($"The money is enough - it would cost {cost:F2}lv.");
            }
            else
            {
                float razlikaNujna = Math.Abs(cost - moneyHad);
                Console.WriteLine($"John will need {razlikaNujna:F2}lv more.");
            }

        }
    }
}
