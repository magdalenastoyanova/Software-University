using System;
using System.Collections.Generic;
using System.Linq;

namespace changeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string line = Console.ReadLine();
          
            while (line != "end")
            {
                string[] tokens = line.Split(' ');
                string cmd = tokens[0];
              
                if (cmd == "Delete")
                {
                    int element = int.Parse(tokens[1]);

                    numbers.RemoveAll(el => el == element);
                }
                else if (cmd == "Insert")
                {
                    int element = int.Parse(tokens[1]);
                    int position = int.Parse(tokens[2]);
                    
                    numbers.Insert(position, element);
                }
               
                line = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
