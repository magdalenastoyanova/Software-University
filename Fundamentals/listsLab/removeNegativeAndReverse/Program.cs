using System;
using System.Collections.Generic;
using System.Linq;

namespace removeNegativeAndReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> positives = new List<int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] > 0)
                {
                    positives.Add(numbers[i]);
                }
            }
            positives.Reverse();

            if (positives.Count == 0)
            {
                Console.WriteLine("empty");
                return;
            }
            Console.WriteLine(string.Join(" ", positives));
         }
    }
}
