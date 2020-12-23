using System;

namespace addAndSubstract
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            int sum = Sum(num1, num2);
            using System;

namespace addAndSubstract
    {
        class Program
        {
            static void Main(string[] args)
            {
                int num1 = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());
                int num3 = int.Parse(Console.ReadLine());

                int sum = Sum(num1, num2);
                int finalResult = Substract(sum, num3);
                Console.WriteLine(finalResult);
            }

            static int Sum(int a, int b)
            {
                int sum = a + b;

                return sum;
            }

            static int Substract(int sum, int c)
            {
                int finalResult = sum - c;

                return finalResult;
            }
        }
    }

    Console.WriteLine(finalResult);
        }

        static int Sum (int a, int b)
        {
            int sum = a + b;

            return sum;
        }

        static int Substract (int sum, int c)
        {
            int finalResult = sum - c;

            return finalResult;
        }
    }
}
