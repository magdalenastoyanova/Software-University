using System;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());

            Fail(n);
            Poor(n);
            Good(n);
            VeryGood(n);
            Excellent(n);
        }
        static void Fail(double n)
        {
            if (n >= 2.00 && n <= 2.99 )
            {
                Console.WriteLine("Fail");
            }
        }
        static void Poor(double n)
        {
            if (n >= 3.00 && n <= 3.49)
            {
                Console.WriteLine("Poor");
            }
        }
        static void Good(double n)
        {
            if (n >= 3.50 && n <= 4.49)
            {
                Console.WriteLine("Good");
            }
        }
        static void VeryGood(double n)
        {
            if (n >= 4.50 && n <= 5.49)
            {
                Console.WriteLine("Very good");
            }
        }
        static void Excellent(double n)
        {
            if (n >= 5.50 && n <= 6.00)
            {
                Console.WriteLine("Excellent");
            }
        }
    }
}
