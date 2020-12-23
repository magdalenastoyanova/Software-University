using System;
using System.Linq;

namespace topInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] arr = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
            string result = "";
           
            for (int i = 0; i < arr.Length; i++)
            {
                int current = arr[i];
                bool isTopInteger = true;

                for (int index = i + 1; index < arr.Length; index++)
                {
                    if (current <= arr[index])
                    {
                        isTopInteger = false;
                        break;
                    }
                }
                if (isTopInteger)
                {
                    result += current + " ";
                }
            }
            Console.WriteLine(result);
        }
    }
}
