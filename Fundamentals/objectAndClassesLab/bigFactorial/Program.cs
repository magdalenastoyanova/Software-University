using System;
using System.Numerics;

namespace bigFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger factorial = 1;
            int N = int.Parse(Console.ReadLine());
           
            for (int i = 2; i <= N; i++)
            {
                factorial = factorial * i;
            }
            Console.WriteLine(factorial);
        }
    }
}
