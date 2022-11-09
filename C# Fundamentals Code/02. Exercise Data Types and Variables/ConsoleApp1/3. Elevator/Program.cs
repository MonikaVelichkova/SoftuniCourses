using System;

namespace _3._Elevator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var peopleN = double.Parse(Console.ReadLine());
            var capacP = double.Parse(Console.ReadLine());

            int courses = (int)Math.Ceiling((double)peopleN / capacP);

            Console.WriteLine(courses);

        }
    }
}
