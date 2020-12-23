using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> text = Console.ReadLine().Split("|").ToList();
            text.Reverse();

            for (int i = 0; i < text.Count; i++)
            {
                string[] numbers = text[i].Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (var item in numbers)
                {
                    Console.Write(item + " ");
                }
            }
            
        }
    }
}
