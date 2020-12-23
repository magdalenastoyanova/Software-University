using System;
using System.Linq;

namespace LadyBugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[] initialLadybugIndexes = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int[] field = new int[size];
            foreach (int index in initialLadybugIndexes)
            {
                if (index < 0 || index > size - 1)
                {
                    continue;
                }
                field[index] = 1;
            }
            string command = null;

            while ((command = Console.ReadLine()) != "end")
            {
                string[] tokens = command.Split();
                int ladybugIndex = int.Parse(tokens[0]);
                string position = tokens[1];
                int flyLength = int.Parse(tokens[2]);

                if (ladybugIndex < 0 || ladybugIndex >= size || field[ladybugIndex] != 1)
                {
                    continue;
                }
                if (position == "right")
                {
                    field[ladybugIndex] = 0;
                    int newIndex = ladybugIndex = flyLength;

                    while (newIndex <  size)
                    {
                        if (field[newIndex] == 1)
                        {
                            newIndex += flyLength;
                            continue;
                        }
                        field[newIndex] = 1;
                        break;
                    }
                }
                else if (position == "left")
                {
                    field[ladybugIndex] = 0;
                    int newIndex = ladybugIndex - flyLength;

                    while (newIndex >= 0)
                    {
                        if (field[newIndex] == 1)
                        {
                            newIndex -= flyLength;
                            continue;
                        }
                        field[newIndex] = 1;
                        break;
                    }
                }
            }

            Console.WriteLine(string.Join(" ", field));
        }
    }
}
