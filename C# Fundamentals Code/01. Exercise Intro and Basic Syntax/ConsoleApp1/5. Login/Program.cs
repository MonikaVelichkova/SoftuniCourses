using System;

namespace _5._Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userN = Console.ReadLine();
            string passw = Console.ReadLine();
            string userRev = string.Empty;

            for (int i = userN.Length - 1; i >= 0; i--)
            {
                userRev += userN[i];
            }
            int count = 0;
            while (passw != userRev)
            {
                if (count == 3)
                {
                    Console.WriteLine($"User {userN} blocked!");
                    return;
                }
                count++;
                Console.WriteLine("Incorrect password. Try again.");
                passw = Console.ReadLine();
            }
            Console.WriteLine($"User {userN} logged in.");

        }
    }
}
