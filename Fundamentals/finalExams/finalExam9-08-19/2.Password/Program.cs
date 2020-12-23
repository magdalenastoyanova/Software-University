using System;
using System.Text.RegularExpressions;

namespace _2.Password
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string password = Console.ReadLine();

                Regex reg = new Regex(@"^(.+)>(?<first>\d{3})\|(?<second>[a-z]{3})\|(?<third>[A-Z]{3})\|(?<fourth>[^<>]{3})<\1$");

                var match = reg.Match(password);

                if (match.Success)
                {
                    Console.WriteLine($"Password: {match.Groups["first"].Value}{match.Groups["second"].Value}{match.Groups["third"].Value}{match.Groups["fourth"].Value}");
                }
                else
                {
                    Console.WriteLine($"Try another password!");
                }
            }
        }
    }
}
