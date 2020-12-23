using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            string day = Console.ReadLine();
            string group = Console.ReadLine();
            int numOfPeole = int.Parse(Console.ReadLine());
            decimal pricePerPerson = 0;
            decimal totalPrice = 0;

            if (day == "Friday" && group == "Students")
            {
                pricePerPerson =  8.45M;  
            }
            else if (day == "Saturday" && group == "Students")
            {
                pricePerPerson =  9.80M;
            }
            else if (day == "Sunday" && group == "Students")
            {
                pricePerPerson = 10.46M;    
            }
            else if (day == "Friday" && group == "Business")
                {
                pricePerPerson = 10.90M;
                }
                else if (day == "Saturday" && group == "Business")
                {
                pricePerPerson = 15.60M;
                }
                else if (day == "Sunday" && group == "Business")
                {
                pricePerPerson = 16;
                }
                else if (day == "Friday" && group == "Regular")
                {
                pricePerPerson = 15M;
                }
                else if (day == "Saturday" && group == "Regular")
                {
                  pricePerPerson =  20M;
                }
                else if (day == "Sunday" && group == "Business")
                {
                pricePerPerson = 22.50M;
                }
             totalPrice = numOfPeole * pricePerPerson;

            if ( group == "Students" && numOfPeole >= 30)
            {
                totalPrice = totalPrice * 0.85M;
            }
            else if (numOfPeole >= 100)
                {
                totalPrice -= pricePerPerson * 10M; 
                }
           else if (group == "Regular" && numOfPeole >= 10 && numOfPeole <= 20)
            {
                totalPrice = totalPrice * 0.95M;
            }
            Console.WriteLine($"Total price: {totalPrice:F2}");
            }
        }
    }
}
