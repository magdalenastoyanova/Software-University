using System;

namespace Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            if (command == "add")
            {
                Add(num1, num2, command);
            }
            if (command =="multiply")
            {
                Multiply(num1, num2, command);
            }
            if (command == "subtract")
            {
               Subtract(num1, num2, command);
            }
            if (command == "divide")
            {
                Divide(num1, num2, command);
            }
        }
        static void Add(int num1, int num2, string command)
        {
            string v  = "add";
            if (v == "add")
            {
                int sum = num1 + num2;
                Console.WriteLine(sum);
            }
        }
        static void Multiply(int num1, int num2, string command)
        {
            string v = "multiply";
            if (v == "multiply")
            {
                int sum = num1 * num2;
                Console.WriteLine(sum);
            }
        }
        static void Subtract(int num1, int num2, string command)
        {
            string v = "subtract";
            if (v == "subtract")
            {
                int sum = num1 - num2;
                Console.WriteLine(sum);
            }
        }
        static void Divide(int num1, int num2, string command)
        {
            string v = "divide";
            if (v == "divide")
            {
                int sum = num1 / num2;
                Console.WriteLine(sum);
            }
        }

    }
}
