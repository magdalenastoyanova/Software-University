using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUniParking
{
    class Program
    {
        static void Main(string[] args)
        {
            int numCommands = int.Parse(Console.ReadLine());

            Dictionary<string, string> userLicense = new Dictionary<string, string>();

            for (int i = 0; i < numCommands; i++)
            {
                var input = Console.ReadLine().Split(' ');
                var command = input[0];
                var username = input[1];

                if (input[0] == "register")
                {
                    var license = input[2];

                    if (!userLicense.ContainsKey(username))
                    {
                        if (!userLicense.ContainsKey(license))
                        {
                            userLicense[username] = license;
                            Console.WriteLine($"{username} registered {license} successfully");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {license}");
                    }

                }
                else
                {
                    if (!userLicense.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: user {username} not found");
                    }
                    else
                    {
                        userLicense.Remove(username);
                        Console.WriteLine($"{username} unregistered successfully");
                    }
                }
            }
            Console.WriteLine(string.Join(Environment.NewLine, userLicense.Select(x => $"{x.Key} => {x.Value}")));
        }
    }
}
