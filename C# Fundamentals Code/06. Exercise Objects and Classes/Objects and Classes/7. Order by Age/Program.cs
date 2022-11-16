using System;
using System.Collections.Generic;
using System.Linq;

namespace _7._Order_by_Age
{
    internal class Program
    {
        class Person
        {
            public string Name { get; set; }
            public string ID { get; set; }
            public int Age { get; set; }

            public override string ToString()
            {
                return $"{this.Name} with ID: {this.ID} is {this.Age} years old.";
            }
        }

        static void Main(string[] args)
        {
            List<Person> listOfPeople = new List<Person>();
            string[] peopleDataRead = Console.ReadLine().Split();

            while (peopleDataRead[0] != "End")
            {
                string name = peopleDataRead[0];
                string ID = peopleDataRead[1];
                int age = int.Parse(peopleDataRead[2]);

                Person person = new Person()
                {
                    Name = name,
                    ID = ID,
                    Age = age
                };

                listOfPeople.Add(person);
                peopleDataRead = Console.ReadLine().Split();
            }

            listOfPeople.OrderBy(p => p.Age)
                    .ToList()
                    .ForEach(p => Console.WriteLine(p));
        }
    }
}
