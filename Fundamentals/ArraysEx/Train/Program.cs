﻿using System;
using System.Linq;
namespace ArraysEx
{
    class Program
    {
        static void Main(string[] args)
           
        {
            int count = int.Parse(Console.ReadLine());
            int[] train = new int[count];

            for (int i = 0; i < count; i++)
            {
                train[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(string.Join(" ",train));
            Console.WriteLine(train.Sum());
        }
    }
}
