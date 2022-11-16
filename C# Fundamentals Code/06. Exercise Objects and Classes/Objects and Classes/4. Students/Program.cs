using System;
using System.Collections.Generic;
using System.Linq;

namespace _4._Students
{
    internal class Program
    {
        class Student
        {
            public Student()
            {

            }

            public string FirstName { get; set; }
            public string LastName { get; set; }
            public double Grade { get; set; }

            public override string ToString()
            {
                return $"{this.FirstName} {this.LastName}: {this.Grade:f2}";
            }
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Student> students = new List<Student>();

            for (int i = 0; i < n; i++)
            {
                string[] studentInfo = Console.ReadLine().Split();
                Student student = new Student()
                {
                    FirstName = studentInfo[0],
                    LastName = studentInfo[1],
                    Grade = double.Parse(studentInfo[2]),
                };
                students.Add(student);
            }
            students.OrderByDescending(n => n.Grade).ToList().ForEach(n => Console.WriteLine(n));

        }
    }
}