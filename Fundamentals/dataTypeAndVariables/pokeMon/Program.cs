using System;

namespace pokeMon
{
    class Program
    {
        static void Main(string[] args)
        {
            int power = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());
            int pokes = 0;
            double halfInitialPower = 1.0 * power / 2;

            while (power >= distance)
            {
                power -= distance;
                pokes++;

                if (power == halfInitialPower)
                {
                    if (exhaustionFactor != 0)
                    {
                        power /= exhaustionFactor;
                    }
                }
            }
            Console.WriteLine(power);
            Console.WriteLine(pokes);
        }
    }
}
