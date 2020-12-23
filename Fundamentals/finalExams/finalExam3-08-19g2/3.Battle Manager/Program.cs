using System;
using System.Collections.Generic;
using System.Linq;

namespace _3.Battle_Manager
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> nameAndHealth = new Dictionary<string, int>();
            Dictionary<string, int> nameAndEnergy = new Dictionary<string, int>();

            string commands = Console.ReadLine();

            while (commands != "Results")
            {
                string[] commandArgs = commands.Split(":");
                string command = commandArgs[0];

                if (command == "Add")
                {
                    string personName = commandArgs[1];
                    int health = int.Parse(commandArgs[2]);
                    int energy = int.Parse(commandArgs[3]);

                    if (!nameAndHealth.ContainsKey(personName) && !nameAndEnergy.ContainsKey(personName))
                    {
                        nameAndHealth[personName] = health;
                        nameAndEnergy[personName] = energy;
                    }

                    else
                    {
                        nameAndHealth[personName] += health;
                    }

                }

                else if (command == "Attack")
                {
                    string attackerName = commandArgs[1];
                    string defenderName = commandArgs[2];
                    int damage = int.Parse(commandArgs[3]);

                    if (nameAndHealth.ContainsKey(attackerName) && nameAndHealth.ContainsKey(defenderName))
                    {
                        nameAndHealth[defenderName] -= damage;

                        if (nameAndHealth[defenderName] <= 0)
                        {
                            nameAndHealth.Remove(defenderName);
                            nameAndEnergy.Remove(defenderName);
                            Console.WriteLine($"{defenderName} was disqualified!");
                        }

                        nameAndEnergy[attackerName]--;

                        if (nameAndEnergy[attackerName] == 0)
                        {
                            nameAndHealth.Remove(attackerName);
                            nameAndEnergy.Remove(attackerName);
                            Console.WriteLine($"{attackerName} was disqualified!");
                        }

                    }

                }

                else if (command == "Delete")
                {
                    string username = commandArgs[1];

                    if (nameAndEnergy.ContainsKey(username))
                    {
                        nameAndEnergy.Remove(username);
                    }

                    if (nameAndHealth.ContainsKey(username))
                    {
                        nameAndHealth.Remove(username);
                    }

                    if (username == "All")
                    {
                        nameAndHealth.Clear();
                        nameAndEnergy.Clear();
                    }
                }

                commands = Console.ReadLine();
            }

            Console.WriteLine($"People count: {nameAndHealth.Count}");

            nameAndHealth = nameAndHealth
                .OrderByDescending(health => health.Value)
                .ThenBy(name => name.Key)
                .ToDictionary(a => a.Key, b => b.Value);

           
                foreach (var kvp in nameAndHealth)
                {
                    Console.WriteLine($"{kvp.Key} - {kvp.Value} - {nameAndEnergy[kvp.Key]}");
                }
            
        }
    }
}
