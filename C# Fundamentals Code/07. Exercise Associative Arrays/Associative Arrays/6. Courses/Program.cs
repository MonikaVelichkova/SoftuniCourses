using System;
using System.Collections.Generic;
using System.Linq;

namespace _6._Courses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();
            string[] input = Console.ReadLine().Split(" : ");

            while (input[0] != "end")
            {
                string course = input[0];
                string student = input[1];

                if (!courses.ContainsKey(course))
                {
                    courses.Add(course, new List<string>());
                }
                if (!courses[course].Contains(student))
                {
                    courses[course].Add(student);
                }

                input = Console.ReadLine().Split(" : ");
            }

            foreach (var c in courses.OrderByDescending(c => c.Value.Count()))
            {
                Console.WriteLine($"{c.Key}: {c.Value.Count()}");
                foreach (string user in c.Value.OrderBy(n => n))
                {
                    Console.WriteLine($"-- {user}");
                }
            }
        }
    }
}
