using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Heroes_of_Code_and_Logic_VII
{
    class Program
    {
        static void Main(string[] args)
        {
            int herroes = int.Parse(Console.ReadLine());
            string command = "";
            Dictionary<string, int[]> heroesOfCode = new Dictionary<string, int[]>();


            for (int i = 0; i < herroes; i++)
            {
                string[] heroesList = Console.ReadLine().Split(" ");
                string name = heroesList[0];
                int hp = int.Parse(heroesList[1]);
                int mp = int.Parse(heroesList[2]);
                if (hp > 100 || mp > 200)
                {
                    heroesList = Console.ReadLine().Split(" ");

                    heroesOfCode.Add(name, new int[2] { hp, mp });
                    continue;
                }
                heroesOfCode.Add(name, new int[2] { hp, mp });

            }
            while ((command = Console.ReadLine()) != "End")
            {
                string[] split = command.Split(" - ");

                if (command.Contains("CastSpell"))
                {
                    string heroName = split[1];
                    int mpNeeded = int.Parse(split[2]);
                    string spellName = split[3];
                    if (heroesOfCode[heroName][1] >= mpNeeded)
                    {
                        int mp = heroesOfCode[heroName][1] - mpNeeded;
                        Console.WriteLine($"{heroName} has successfully cast {spellName} and now has {mp} MP!");
                        heroesOfCode[heroName][1] = mp;
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} does not have enough MP to cast {spellName}!");
                    }


                }

                if (command.Contains("TakeDamage"))
                {
                    string heroName = split[1];
                    int damage = int.Parse(split[2]);
                    string attacker = split[3];

                    heroesOfCode[heroName][0] -= damage;
                    if (heroesOfCode[heroName][0] > 0)
                    {
                        Console.WriteLine($"{heroName} was hit for {damage} HP by {attacker} and now has {heroesOfCode[heroName][0]} HP left!");
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} has been killed by {attacker}!");
                        heroesOfCode.Remove(heroName);
                    }
                }

                if (command.Contains("Recharge"))
                {
                    string heroName = split[1];
                    int amount = int.Parse(split[2]);
                    int newMana = amount + heroesOfCode[heroName][1];
                    if (newMana > 200)
                    {
                        newMana = 200;
                        Console.WriteLine($"{heroName} recharged for {200 - heroesOfCode[heroName][1]} MP!");
                        heroesOfCode[heroName][1] = newMana;
                        continue;
                    }
                    Console.WriteLine($"{heroName} recharged for {amount} MP!");
                    heroesOfCode[heroName][1] = newMana;
                }

                if (command.Contains("Heal"))
                {

                    string heroName = split[1];
                    int amount = int.Parse(split[2]);
                    int newHealt = amount + heroesOfCode[heroName][0];

                    if (newHealt > 100)
                    {
                        newHealt = 100;
                        Console.WriteLine($"{heroName} healed for {100 - heroesOfCode[heroName][0]} HP!");
                        heroesOfCode[heroName][0] = newHealt;
                        continue;
                    }
                    Console.WriteLine($"{heroName} healed for {amount} HP!");
                    heroesOfCode[heroName][0] = newHealt;

                }



            }
            //heroesOfCode.Add(heroesHP.Keys,new int[] { heroesHP.Values, heroesMP.Values });

            heroesOfCode = heroesOfCode.OrderByDescending(f => f.Value[0]).ThenBy(f => f.Key).ToDictionary(f => f.Key, f => f.Value);


            foreach (var heroes in heroesOfCode)
            {
                Console.WriteLine($"{heroes.Key}");
                Console.WriteLine($"  HP: {heroes.Value[0]}");
                Console.WriteLine($"  MP: {heroes.Value[1]}");

            }
        }
    }
}
    