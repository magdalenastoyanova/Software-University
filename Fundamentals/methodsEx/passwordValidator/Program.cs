using System;

namespace passwordValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            if (!IsValidLength(password))
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (!IsLetterOrDigit(password))
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (!HasAtLeastTwoDigis(password))
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
            if (IsValidLength(password) && IsLetterOrDigit(password) && HasAtLeastTwoDigis(password))
            {
                Console.WriteLine("Password is valid");
            }
        }
        static bool IsValidLength(string password)
        {
                return password.Length >= 6 && password.Length <= 10;
            
        }
        static bool IsLetterOrDigit(string password)
        {
            foreach (char symbol in password)
            {
                if (!char.IsLetterOrDigit(symbol))
                {
                    return false;
                }
            }
            return true;
        }
        static bool HasAtLeastTwoDigis(string password)
        {
            int digitsCounter = 0;

            foreach (char symbol in password)
            {
                if (char.IsDigit(symbol))
                {
                     digitsCounter++;
                }
            }
            return digitsCounter >= 2;
        }
    }
}
