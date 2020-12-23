using System;

namespace BeerKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int numKegs = int.Parse(Console.ReadLine());
            double bestvolume = 0;
            string bestModel = string.Empty;
  ;            for (int i = 1; i <= numKegs; i++)
            {
                string model = Console.ReadLine();
                double r = double.Parse(Console.ReadLine());
                int h = int.Parse(Console.ReadLine());
               double volume = Math.PI * r * r * h;
                if (volume > bestvolume)
                {
                    bestvolume = volume;
                    bestModel = model;
                }
                
            }
            Console.WriteLine(bestModel);
        }
    }
}
