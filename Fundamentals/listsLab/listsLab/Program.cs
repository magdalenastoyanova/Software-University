using System;
using System.Collections.Generic;
using System.Linq;

namespace listsLab
{
    class Program
    {
        static void Main(string[] args)
        {

            var list1 = Console.ReadLine().Split(' ').Select(double.Parse).ToList();


            GetSum(list1);


        }

        private static void GetSum(List<double> list1)
        {

            int n = 0;
            while (n < list1.Count - 1)
            {
                for (int j = 0; j < 1; j++)
                {
                    if (list1[n] == list1[n + 1])
                    {
                        double sum = list1[n] + list1[n + 1];
                        list1[n] = sum;
                        list1.Remove(list1[n + 1]);
                        n = 0;
                    }
                    else
                    {
                        n++;
                        break;

                    }
                }
            }

            Console.WriteLine(string.Join(" ", list1));
        }
    }
}
