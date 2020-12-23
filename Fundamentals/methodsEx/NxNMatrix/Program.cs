using System;

namespace NxNMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            PrintTheMatrix(number);
            
        }

        static void PrintTheMatrix (int number)
        {
            for (int i = 0; i < number; i++)
            {
                for (int j = 0; j < number; j++)
                {
                    Console.WriteLine(number + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
