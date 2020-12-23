using System;
using System.Collections.Generic;
using System.Linq;

namespace PokemonDon_tGo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> line = Console.ReadLine().Split().Select(int.Parse).ToList();
            int sum = 0;
            while (line.Count > 0)
            {
            int index = int.Parse(Console.ReadLine());
                int element;

                if (index < 0)
                {
                    element = line[0];
                    line[0] = line[line.Count - 1];
                }
                else if (index >= line.Count )
                {
                    element = line[line.Count - 1];
                    line[line.Count - 1] = line[0];
                }
                else
                {
                    element = line[index];
                    line.RemoveAt(index);
                }
                sum += element;
               
                for (int i = 0; i < line.Count; i++)
                {
                    if (line[i] <= element)
                    {
                        line[i] += element;
                    }
                    else
                    {
                        line[i] -= element;
                    }
                }
            }
            Console.WriteLine(sum);
        }
    }
}
