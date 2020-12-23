using System;

namespace factorialDivsion
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            double firstFactorial = CalculateFactorial(firstNum);
            double secondFactorial = CalculateFactorial(secondNum);
            
            double output = firstFactorial / secondFactorial;
           
            Console.WriteLine($"{output:F2}");
        }

        static double CalculateFactorial(double n)
        {
            double factorial = 1;

            for (double i = n; i >= 1; i--)
            {
                factorial *= i;
            }
            return factorial;
        }
    }
}
