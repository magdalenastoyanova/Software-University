using System;

namespace triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Print(n);
        }
        static void PrintLine(int start, int end)
        {
            for (int i = start; i < end; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
        static void Print(int n)
        { 
          for (int i = 1; i <= n; i++)
            {
                PrintLine(1, i);

                for (int j = n - 1; j >= n; j--)
                {
                    PrintLine(1, i);
                }
                
            }  
        }
    }
}
