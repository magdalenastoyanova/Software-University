using System;
using System.Text.RegularExpressions;

namespace RegexLab
{
    class Program
    {
        static void Main(string[] args)
        {
            string names = Console.ReadLine();
            string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+";
           
            Regex regex = new Regex(pattern);

            MatchCollection validNames = regex.Matches(names);

            foreach (Match name in validNames)
            {
                Console.Write($"{name.Value}" + " ");
            }
            Console.WriteLine();
        }
    }
}
