using System;
using System.Collections.Generic;

namespace _8._Company_Users
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> companyEmployees = new Dictionary<string, List<string>>();
            string[] employeesData = Console.ReadLine().Split(" -> ");

            while (employeesData[0] != "End")
            {
                string company = employeesData[0];
                string employID = employeesData[1];

                if (!companyEmployees.ContainsKey(company))
                {
                    companyEmployees.Add(company, new List<string>());
                }

                if (!companyEmployees[company].Contains(employID))
                {
                    companyEmployees[company].Add(employID);
                }
                employeesData = Console.ReadLine().Split(" -> ");
            }

            foreach (var comp in companyEmployees)
            {
                Console.WriteLine(comp.Key);
                comp.Value.ForEach(id => Console.WriteLine($"-- {id}"));
            }
        }
    }
}
