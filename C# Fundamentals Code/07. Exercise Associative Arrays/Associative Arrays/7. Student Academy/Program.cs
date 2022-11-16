using System;
using System.Collections.Generic;
using System.Linq;

namespace _7._Student_Academy
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            Dictionary<string, List<double>> studentsGrades = new Dictionary<string, List<double>>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string student = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!studentsGrades.ContainsKey(student))
                {
                    studentsGrades.Add(student, new List<double>());
                }
                studentsGrades[student].Add(grade);
            }
            foreach (var stud in studentsGrades.Where(s => s.Value.Average() >= 4.50))
            {
                Console.WriteLine($"{stud.Key} -> {stud.Value.Average():F2}");
            }
        }
    }
}
