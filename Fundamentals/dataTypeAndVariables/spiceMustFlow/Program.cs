using System;

namespace spiceMustFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingYield = int.Parse(Console.ReadLine());
            int decrease = 10;
            int totalAmount = 0;
            int spiceForTheCrew = 26;
            int days = 0;
           
            while (startingYield >= 100)
            {
                days++;
                int yieldSpiceForTheDay = startingYield;
                if (yieldSpiceForTheDay > spiceForTheCrew)
                {
                    yieldSpiceForTheDay -= spiceForTheCrew;
                }
                startingYield -= decrease;
                totalAmount += yieldSpiceForTheDay;
                if (startingYield < 100)
                {
                    break;
                }
            }
            if (totalAmount > spiceForTheCrew)
            {
                totalAmount -= spiceForTheCrew;
            }
            Console.WriteLine($"{days}");
            Console.WriteLine($"{totalAmount}");
        }
    }
}
