using System;
using System.Linq;

namespace reverseArrayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split(' ').ToArray();

            for (int i = 0; i < arr.Length / 2; i++)
            {
                var oldElement = arr[i];
                arr[i] = arr[arr.Length - i - 1];
                arr[arr.Length - i - 1] = oldElement;
            }

            Console.Write(string.Join((" "), arr));
        }
    }
}
