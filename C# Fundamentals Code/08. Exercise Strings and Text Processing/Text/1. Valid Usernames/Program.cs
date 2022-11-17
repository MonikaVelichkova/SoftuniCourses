using System;
using System.Collections.Generic;

namespace _1._Valid_Usernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine().Split(", ");
            List<string> validUserN = new List<string>();

            foreach (string user in usernames)
            {
                if (user.Length >= 3 && user.Length <= 16)
                {
                    bool isValid = true;
                    foreach (char s in user)
                    {
                        if (!(char.IsLetterOrDigit(s) || s == '-' || s == '_'))
                        {
                            isValid = false;
                            break;
                        }
                    }
                    if (isValid)
                    {
                        validUserN.Add(user);
                    }
                }
            }
            Console.WriteLine(string.Join(Environment.NewLine, validUserN));
        }
    }
}
