using System;
using System.Linq;

namespace textProcessingEx
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(", ", StringSplitOptions.None).ToArray();

            foreach (var username in words)
            {
                if (ValidateUsername(username))
                {
                    Console.WriteLine(username);
                }
            }
        }
        private static bool ValidateUsername(string username) 
        {
            
            if (username.Length < 3 || username.Length > 16)
            {
                return false;
            }

            bool isValid = true;

            for (int i = 0; i < username.Length; i++)
            {
                char currentCh = username[i];

                if (!(Char.IsLetterOrDigit(currentCh) || currentCh == '-' || currentCh == '_'))
                {
                    isValid = false;
                    break;
                }
            }
            return isValid;
        }
    }
    
}
