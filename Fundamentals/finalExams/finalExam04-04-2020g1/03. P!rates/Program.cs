using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._P_rates
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> cityPop = new Dictionary<string, int>();
            Dictionary<string, int> cityGold = new Dictionary<string, int>();
            string command;

            while ((command = Console.ReadLine()) != "Sail")
            {
                string[] tokens = command.Split("||");
                string cityName = tokens[0];
                int _cityPop = int.Parse(tokens[1]);
                int _cityGold = int.Parse(tokens[2]);

                if (cityPop.ContainsKey(cityName))
                {
                    cityPop[cityName] += _cityPop;
                    cityGold[cityName] += _cityGold;
                }
                else
                {
                    cityPop.Add(cityName, _cityPop);
                    cityGold.Add(cityName, _cityGold);
                }
            }

            while ((command = Console.ReadLine()) != "End")
            {
                string[] tokens = command.Split("=>");
                string cityToPlunder = tokens[1];

                if (tokens[0] == "Plunder")
                {
                    int peopleKilled = int.Parse(tokens[2]);
                    int goldStolen = int.Parse(tokens[3]);
                    Console.WriteLine($"{cityToPlunder} plundered! {goldStolen} gold stolen, {peopleKilled} citizens killed.");
                    cityPop[cityToPlunder] -= peopleKilled;
                    cityGold[cityToPlunder] -= goldStolen;

                    if (cityPop[cityToPlunder] <= 0 || cityGold[cityToPlunder] <= 0)
                    {
                        Console.WriteLine($"{cityToPlunder} has been wiped off the map!");
                        cityPop.Remove(cityToPlunder);
                        cityGold.Remove(cityToPlunder);
                    }
                }
                if (tokens[0] == "Prosper")
                {
                    string cityProsper = tokens[1];
                    int goldAdd = int.Parse(tokens[2]);

                    if (goldAdd < 0) Console.WriteLine($"Gold added cannot be a negative number!");
                    else
                    {
                        cityGold[cityProsper] += goldAdd;
                        Console.WriteLine($"{goldAdd} gold added to the city treasury. {cityProsper} now has {cityGold[cityProsper]} gold.");
                    }
                }
            }

            cityGold = cityGold.OrderByDescending(s => s.Value).ThenBy(s => s.Key).ToDictionary(s => s.Key, s => s.Value);

            if (cityGold.Count >= 1)
            {
                Console.WriteLine($"Ahoy, Captain! There are {cityGold.Count} wealthy settlements to go to:");
                foreach (KeyValuePair<string, int> item in cityGold)
                {
                    Console.WriteLine($"{item.Key} -> Population: {cityPop[item.Key]} citizens, Gold: {item.Value} kg");
                }
            }
            else if (cityGold.Count < 1)
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
            }
        }
    }
}
