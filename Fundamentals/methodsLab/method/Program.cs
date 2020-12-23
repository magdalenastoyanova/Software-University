using System;

namespace methodsLab
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            PrintThePositive(n);
            PrintTheNegative(n);
            PrintZero(n);
        }
        static void PrintThePositive(int n)
        {
            if (n > 0)
            {
                Console.WriteLine($"The number {n} is positive.");  
            }
        }

        static void PrintTheNegative(int n)
        {
            if (n < 0)
            {
                Console.WriteLine($"The number {n} is negative.");
            }

        }

        static void PrintZero(int n)
        {
            if (n == 0)
            {
                Console.WriteLine($"The number {n} is zero.");
            }

        }
    }
}
