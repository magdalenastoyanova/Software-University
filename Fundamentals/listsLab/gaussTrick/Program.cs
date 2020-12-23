using System;
using System.Linq;
using System.Collections.Generic;

namespace gaussTrick
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> list = PrintList();

            for (int i = 0; i < list.Count/2; i++)
            {
                Console.Write(list[i] + list[list.Count - 1 - i] + " ");
            }
            if (list.Count % 2 == 1)
            {
                Console.Write(list[list.Count/2]);
            }
        }

        static List<int> PrintList ()
        {
            List<int> list = new List<int>();
            string line = Console.ReadLine();
            
            list =line.Split().Select(int.Parse).ToList();
            return list;
        }

    }
}
