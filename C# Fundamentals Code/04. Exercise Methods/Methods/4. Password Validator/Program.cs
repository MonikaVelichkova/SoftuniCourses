using System;
using System.Linq;

namespace _4._Password_Validator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            PassValid(input);
        }
        private static void PassValid(string input)
        {
            int count = 0;
            if (input.Length >= 6 && input.Length <= 10)
            {
                count++;
            }
            else
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }

            bool result = input.All(Char.IsLetterOrDigit);
            if (result == true)
            {
                count++;
            }
            else
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }

            bool lenghtPass = ValidatePasswordDigitCount(input);
            if (lenghtPass == true)
            {
                count++;
            }
            else
            {
                Console.WriteLine("Password must have at least 2 digits");
            }

            if (count == 3)
            {
                Console.WriteLine("Password is valid");
            }

        }

        private static bool ValidatePasswordDigitCount(string pass)
        {
            int digitCount = 0;
            foreach (char digit in pass)
            {
                if (digit >= 48 && digit <= 57)
                {
                    digitCount++;
                }
            }
            return digitCount < 2 ? false : true;
        }
    }
}
/*
 
4-та зад., 2-ри начин:
static void Main(string[] args)
        {
            string password = Console.ReadLine();
            ValidatePassword(password);
        }

        public static void ValidatePassword(string password)
        {
            bool isPasswordLengthValid = ValidatePasswordLength(password);
            bool isPasswordCompositionValid = ValidatePasswordComposition(password);
            bool isPasswordDigitsCountValid = ValidatePasswordDigitCount(password);

            if (isPasswordLengthValid && isPasswordCompositionValid && isPasswordDigitsCountValid)
            {
                Console.WriteLine("Password is valid");
            }
            else
            {
                if (!isPasswordLengthValid)
                {
                    Console.WriteLine("Password must be between 6 and 10 characters");
                }

                if (!isPasswordCompositionValid)
                {
                    Console.WriteLine("Password must consist only of letters and digits");
                }

                if (!isPasswordDigitsCountValid)
                {
                    Console.WriteLine("Password must have at least 2 digits");
                }
            }
        }

        public static bool ValidatePasswordLength(string password)
        {
            return (password.Length >= 6 && password.Length <= 10);
        }

        public static bool ValidatePasswordComposition(string password)
        {

            foreach (char digit in password)
            {
                if (!(digit >= 48 && digit <= 57) && !(digit >= 65 && digit <= 90) && !(digit >= 97 && digit <= 122))
                {
                    return false;
                }
            }

            return true;
        }

        public static bool ValidatePasswordDigitCount(string password)
        {
            int digitCount = 0;
            foreach (char digit in password)
            {
                if (digit >= 48 && digit <= 57)
                {
                    digitCount++;
                }
            }

            return digitCount < 2 ? false : true;
        } 
 */