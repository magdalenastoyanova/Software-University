using System;
using System.Collections.Generic;
using System.Linq;

namespace houseParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfCmds = int.Parse(Console.ReadLine());
            List<string> guests = new List<string>();

            string inList = null;

            for (int i = 0; i < numOfCmds; i++)
            {
                numOfCmds = int.Parse(Console.ReadLine());
                string input = Console.ReadLine();

                string[] splited = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (splited[2] == "not")
                {
                    if (guests.Contains(splited[0]))
                    {
                        guests.Remove(splited[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{splited[0]} is not in the list!");
                    }
                }
                else
                {
                    if (guests.Contains(splited[0]))
                    {
                        Console.WriteLine($"{splited[0]} is already in the list!");
                    }
                    else
                    {
                        guests.Add(splited[0]);
                    }
                }
            }
            if (inList != null)
            {
                Console.WriteLine(inList);
            }
            Console.WriteLine(string.Join("\n", guests));
        
        }
    }
}
