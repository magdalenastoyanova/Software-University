using System;
using System.Linq;

namespace evenAndOddSubstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sumOdd = 0;
            int sumEven = 0;
            int result = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNums = numbers[i];
                if (currentNums % 2 == 0)
                {
                    sumEven += currentNums; 
                }
                else 
                {
                    sumOdd += currentNums;
                }
                result = sumEven - sumOdd;
            }
            Console.WriteLine(result);
        }
    }
}
