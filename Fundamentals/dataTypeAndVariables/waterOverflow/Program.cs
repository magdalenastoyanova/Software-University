using System;

namespace waterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfLines = int.Parse(Console.ReadLine());
            int capacity = 0;
            int maxCapacity = 255;

            for (int i = 0; i < numOfLines; i++)
            {
                int liters = int.Parse(Console.ReadLine());
                if (capacity + liters <= maxCapacity)
                {
                    capacity += liters;
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                }

            }
            Console.WriteLine(capacity);
        }
    }
}
