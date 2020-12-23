using System;
using System.Numerics;

namespace snowBalls
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger count = BigInteger.Parse(Console.ReadLine());
            BigInteger bestQuality = 0;
            BigInteger bestSnowballSnow = 0;
            BigInteger bestSnowballTime = 0;
            BigInteger bestSnowballValue = 0;
            for (BigInteger i = 0; i < count; i++)
            {
                BigInteger snowballSnow = BigInteger.Parse(Console.ReadLine());
                BigInteger snowballTime = BigInteger.Parse(Console.ReadLine());
                BigInteger snowballQuality = BigInteger.Parse(Console.ReadLine());
               
                BigInteger snowballValue = (BigInteger)BigInteger.Pow((snowballSnow / snowballTime) , (int)snowballQuality);
                
                if (snowballValue > bestSnowballValue)
                {
                    bestSnowballValue = snowballValue;
                    bestSnowballSnow = snowballSnow;
                    bestSnowballTime = snowballTime;
                    bestQuality= snowballQuality;
                }
            }
            Console.WriteLine($"{bestSnowballSnow} : {bestSnowballTime} = {bestSnowballValue} ({bestQuality})");
        }
    }
}
