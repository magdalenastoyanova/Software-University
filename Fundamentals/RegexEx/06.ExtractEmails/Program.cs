using System;
using System.Text.RegularExpressions;

namespace _06.ExtractEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string pattern = @"(^|(?<=\s))(([a-zA-Z0-9]+)([\.\-_]?)([A-Za-z0-9]+)(@)([a-zA-Z]+([\.\-_][A-Za-z]+)+))(\b|(?=\s))";

            Regex emails = new Regex(pattern);

            MatchCollection collection = Regex.Matches(text, pattern);

            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }

        }
    }
}
