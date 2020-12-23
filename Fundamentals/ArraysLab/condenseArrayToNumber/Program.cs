using System;
using System.Linq;

namespace condenseArrayToNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            
            while (numbers.Length > 1)
            {
                int[] newNumbers = new int[numbers.Length - 1];
                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    newNumbers[i] = numbers[i] + numbers[i + 1];
                }
                numbers = newNumbers;
            }
            Console.WriteLine(numbers[0]);

            }

        }
    }

