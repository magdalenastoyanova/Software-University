using System;
using System.Collections.Generic;
using System.Linq;

namespace listsEx
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine().Split().Select(int.Parse).ToList();
            int maxCapacity = int.Parse(Console.ReadLine());
            string line = Console.ReadLine();
           
            while (line != "end")
            {
                string[] tokens = line.Split(' ');
               
                if (tokens.Length == 2)
                {
                    int wagon = int.Parse(tokens[1]);
                   
                    wagons.Add(wagon);
                }
                else
                {
                    int currentCapacity = int.Parse(tokens[0]);

                    for (int i = 0; i < wagons.Count; i++)
                    {
                        int currentWagon = wagons[i];

                        if (currentWagon + currentCapacity <= maxCapacity)
                        {
                            wagons[i] += currentCapacity;
                            break;
                        }
                    }
                }
                line = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", wagons));
        }
    }
}
