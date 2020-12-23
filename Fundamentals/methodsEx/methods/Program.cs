using System;

namespace methodsEx
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            int smallest = SmallestOfThree(first, second, third);
            Console.WriteLine(smallest);
        }
        static int SmallestOfThree(int a, int b, int c)
        {
            int smallest = 0;
            if (a <= b && a <= c)
            {
                smallest = a;
            }
            else if (b <= a && b <= c)
            {
                smallest = b;
            }
            else
            {
                smallest = c;
            }
            return smallest;
        }
       // static int SmallestOfThree(int a, int b, int c)
       // {
        //    int smallest = Math.Min(a, Math.Min(b, c));
        //}
    }
}
