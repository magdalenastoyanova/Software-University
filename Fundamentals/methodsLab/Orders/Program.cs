using System;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            Orders(product, quantity);
          
        }
        static void Orders(string product, int quantity)
        {
            double sum = 0;
            if (product == "water")
            {
               sum = quantity * 1.00;
            }
 
            else if (product == "coffee")
            {
                sum = quantity * 1.50;
            }

           else if (product == "coke")
            {
                sum = quantity * 1.40;
            }
 
            if (product == "snacks")
            {
                sum = quantity * 2.00;
            }
            Console.WriteLine($"{sum:F2}");
        }
    }
}
