using System;
using System.Text.RegularExpressions;

namespace _2.Message_Encrypter
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"[@|*](?<title>[A-Z][a-z]{2,})[@|*]:\s\[(?<firstLetter>[A-Z]|[a-z])\]\|\[(?<secondLetter>[A-Z]|[a-z])\]\|\[(?<thirdLetter>[A-Z]|[a-z])\]\|$";

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                Match match = Regex.Match(input, pattern);

                if (match.Success)
                {

                    string title = match.Groups["title"].Value;
                    char firstLetter = char.Parse(match.Groups["firstLetter"].Value);
                    char secondLetter = char.Parse(match.Groups["secondLetter"].Value);
                    char thirdLetter = char.Parse(match.Groups["thirdLetter"].Value);

                    Console.WriteLine($"{title}: {(int)firstLetter} {(int)secondLetter} {(int)thirdLetter}");

                }

                else
                {
                    Console.WriteLine("Valid message not found!");
                }
            }
        }
    }
}