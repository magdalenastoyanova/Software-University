using System;

namespace mathPower
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());
            double result = PowerNum(num, power);

            Console.WriteLine(result);
        }

       static double PowerNum(double num, int power)
        {
           

            return Math.Pow(num, power);
        }
    }
}
