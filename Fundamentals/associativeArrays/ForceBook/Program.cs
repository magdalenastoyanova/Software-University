using System;
using System.Collections.Generic;
using System.Linq;

namespace ForceBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> sideMembers = new Dictionary<string, List<string>>();
            string input = Console.ReadLine();

            while (input != "Lumpawaroo")
            {
                if (input.Contains("|"))
                {
                    string[] splittedInput = input.Split(" | ");
                    string side = splittedInput[0];
                    string memberName = splittedInput[1];

                    if (!sideMembers.ContainsKey(side))
                    {
                        sideMembers[side] = new List<string>();
                    }
                    bool memberExist = false;

                    foreach (var kvp in sideMembers)
                    {
                        if (kvp.Value.Contains(memberName))
                        {
                            memberExist = true;
                            break;
                        }
                    }

                    if (!sideMembers[side].Contains(memberName) && !memberExist)
                    {
                        sideMembers[side].Add(memberName);
                    }
                }
                else
                {
                    string[] splittedInput = input.Split(" -> ");

                    string memberName = splittedInput[0];
                    string side = splittedInput[1];

                    bool memberExist = false;
                    string currentSide = "";
                  
                    foreach (var kvp in sideMembers)
                    {
                        if (kvp.Value.Contains(memberName))
                        {
                            memberExist = true;
                            currentSide = kvp.Key;
                            break;
                        }
                    }
                    if (!memberExist)
                    {
                        sideMembers[currentSide].Remove(memberName);
                    }
                    if (!sideMembers.ContainsKey(side))
                    {
                        sideMembers[side] = new List<string>();
                    }
                      sideMembers[side].Add(memberName);
                    
                    Console.WriteLine($"{memberName} joins the {side} side!");
                }
                input = Console.ReadLine();
            }
            sideMembers = sideMembers.Where(x => x.Value.Count > 0).OrderByDescending(x=>x.Value.Count).ThenBy(x => x.Key).ToDictionary(x => x.Key,x=>x.Value);

            foreach (var kvp in sideMembers)
            {
                string sideName = kvp.Key;
                List<string> sidesMembers = kvp.Value;
                sidesMembers.Sort();
                Console.WriteLine($"Side: {sideName}, Members: {sideMembers.Count}");

                foreach (var member in sidesMembers)
                {
                    Console.WriteLine($"! {member}");
                }
            }
        }
    }
}
