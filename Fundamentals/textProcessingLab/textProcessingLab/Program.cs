using System;
using System.Linq;

namespace textProcessingLab
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = null;

            while ((input = Console.ReadLine()) != "end")
            {
                var reversedString = input.ToArray().Reverse();

                Console.WriteLine($"{input} = {string.Join("", reversedString)}");
            }
        }
    }
}
