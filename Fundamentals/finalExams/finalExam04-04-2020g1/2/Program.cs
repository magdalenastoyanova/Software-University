using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text.RegularExpressions;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            string textPattern = @"(::|\*\*)(?<text>[A-Z]{1}[a-z]{2,})\1";
            string numPattern = @"\d";
            BigInteger cool = 1;
            string input = Console.ReadLine();
            MatchCollection numMatches = Regex.Matches(input, numPattern);
            foreach (Match match in numMatches)
            {
                cool *= BigInteger.Parse(match.Value);
            }
            MatchCollection textMatches = Regex.Matches(input, textPattern);
            var emojis = new List<string>();
            foreach (Match match in textMatches)
            {
                int sum = 0;
                foreach (char ch in match.Groups["text"].Value)
                {
                    sum += ch;
                }
                if (sum >= cool)
                {
                    emojis.Add(match.Value);
                }
            }
            Console.WriteLine($"Cool threshold: {cool}");
            Console.WriteLine($"{textMatches.Count} emojis found in the text. The cool ones are:");
           
            if (emojis.Count > 0)
            {
                foreach (var emoji in emojis)
                {
                    Console.WriteLine(emoji);
                }
            }
        }
    }
}
        