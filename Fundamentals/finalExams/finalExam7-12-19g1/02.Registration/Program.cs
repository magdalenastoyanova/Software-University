using System;
using System.Text.RegularExpressions;

namespace _02.Registration
{
    class Program
    {
        static void Main(string[] args)
        {
            int howMany = int.Parse(Console.ReadLine());
            int sumRegistration = 0;
            for (int i = 0; i < howMany; i++)
            {
                string input = Console.ReadLine();
                string pattern = @"U\$(?<username>[A-Z][a-z]{2,})U\$P@\$(?<password>[A-Za-z]{5,}\d+)P@\$";
                Match regisstration = Regex.Match(input, pattern);
                if (regisstration.Success)
                {
                    Console.WriteLine("Registration was successful");
                    Console.WriteLine($"Username: {regisstration.Groups["username"].Value}, Password: {regisstration.Groups["password"].Value}");
                    sumRegistration++;
                }
                else
                {
                    Console.WriteLine("Invalid username or password");
                }
            }
            Console.WriteLine($"Successful registrations: {sumRegistration}");
        }
    }
}
