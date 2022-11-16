using System;
using System.Collections.Generic;

namespace _5._SoftUni_Parking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> parking = new Dictionary<string, string>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string user = input[1];

                switch (input[0])
                {
                    case "register":
                        string plate = input[2];
                        if (!parking.ContainsKey(user))
                        {
                            parking.Add(user, plate);
                            Console.WriteLine($"{user} registered {plate} successfully");
                        }
                        else
                        {
                            Console.WriteLine($"ERROR: already registered with plate number {plate}");
                        }
                        break;

                    case "unregister":
                        if (!parking.ContainsKey(user))
                        {
                            Console.WriteLine($"ERROR: user {user} not found");
                        }
                        else
                        {
                            parking.Remove(user);
                            Console.WriteLine($"{user} unregistered successfully");
                        }
                        break;
                }
            }
            foreach (var u in parking)
            {
                Console.WriteLine($"{u.Key} => {u.Value}");
            }
        }
    }
}
