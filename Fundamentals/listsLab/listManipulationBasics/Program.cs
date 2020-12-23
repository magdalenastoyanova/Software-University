using System;
using System.Collections.Generic;
using System.Linq;

namespace listManipulationBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            string command = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());

            while (command !="end")
            {
                command = Console.ReadLine();

                string[] tokens = command.Split();
                switch (tokens[0])
                {
                    case "Add":
                        int numberToAdd = int.Parse(tokens[1]);
                        list.Add(numberToAdd); break;
                    case "Remove":
                        int numberToRemove = int.Parse(tokens[1]);
                        list.Remove(numberToRemove); break;
                    case "RemoveAt":
                        int indexToRemoveAt = int.Parse(tokens[1]);
                        list.RemoveAt(indexToRemoveAt); break;
                    case "Insert":
                        int numberToInsert = int.Parse(tokens[1]);
                        int indexToInsert = int.Parse(tokens[2]);
                        list.Insert(indexToInsert, numberToInsert); break;
                }
            }
            Console.WriteLine(string.Join(" ", list));
        }
    }
}
