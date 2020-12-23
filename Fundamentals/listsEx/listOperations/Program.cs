using System;
using System.Collections.Generic;
using System.Linq;

namespace listOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string line = Console.ReadLine();

            while (line != "End")
            {
                string[] tokens = line.Split(' ');
                string cmd = tokens[0];

                if (cmd == "Add")
                {
                    int num = int.Parse(tokens[1]);

                    numbers.Add(num);
                }
                else if (cmd == "Insert")
                {
                    int num = int.Parse(tokens[1]);
                    int index = int.Parse(tokens[2]);
                    if (index >= 0 && index < numbers.Count)
                    {
                        numbers.Insert(index, num);
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }

                }
                else if (cmd == "Remove")
                {
                    int index = int.Parse(tokens[1]);
                    if (index >= 0 && index < numbers.Count)
                    {
                        numbers.RemoveAt(index);
                    }

                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                }
                else if (line.Contains("Shift left"))
                {
                    int num = int.Parse(tokens[2]);

                    for (int i = 0; i < num; i++)
                    {
                        int currentNum = numbers[0];
                        numbers.RemoveAt(0);
                        numbers.Add(currentNum);
                    }
                }
                else if (line.Contains("Shift right"))
                {
                    int num = int.Parse(tokens[2]);

                    for (int i = 0; i < num; i++)
                    {
                        int currentNum = numbers[numbers.Count - 1];
                        numbers.RemoveAt(numbers.Count - 1);
                        numbers.Insert(0, currentNum);
                    }
                }
                line = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ",numbers));
        }
            
        }
    }
