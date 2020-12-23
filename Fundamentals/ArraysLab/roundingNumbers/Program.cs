using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace roundingNumbers
{
    class Program

    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            int[] roundednums = new int[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                roundednums[i] = (int)Math.Round(numbers[i], MidpointRounding.AwayFromZero);
               
                Console.WriteLine($"{numbers[i]} => {roundednums[i]}");

            }
           

        }
    }
}
