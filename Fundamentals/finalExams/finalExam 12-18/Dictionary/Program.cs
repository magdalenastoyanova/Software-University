using System;
using System.Collections.Generic;
using System.Linq;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, List<string>> dic = new SortedDictionary<string, List<string>>();
            string[] input = Console.ReadLine().Split(new[] { " | " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            string[] outputOrder = Console.ReadLine().Split(new[] { " | " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            string outputCmd = Console.ReadLine();
            for (int i = 0; i < input.Length; i++)
            {
                string[] toInp = input[i].Split(new[] { ": " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (!dic.ContainsKey(toInp[0]))
                {
                    dic.Add(toInp[0], new List<string> { toInp[1] });
                }
                else
                {
                    dic[toInp[0]].Add(toInp[1]);
                }
            }
            dic.Values.OrderByDescending(t => t.Count());

            if (outputCmd == "List")
            {

                foreach (var n in dic)
                {
                    Console.Write(n.Key + " ");
                }
                Console.WriteLine();
            }
            else
            {
                for (int i = 0; i < outputOrder.Length; i++)
                {
                    if (dic.ContainsKey(outputOrder[i]))
                    {
                        dic.Values.OrderByDescending(t => t.Count());
                        foreach (var n in dic)
                        {
                            n.Value.Sort((a, b) => b.Length.CompareTo(a.Length));
                            //n.Value.Reverse();
                            Console.WriteLine(n.Key);
                            foreach (var k in n.Value)
                            {
                                Console.WriteLine($" -{k}");
                            }
                        }
                    }
                }
            }
        }
    }
}
