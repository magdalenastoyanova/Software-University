using System;
using System.Linq;

namespace maxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
           
            int bestCount = 0;
            int bestIndex = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                int currentElement = arr[i];
                int currentCounter = 1;

                for (int currI = i + 1; currI < arr.Length; currI++)
                {
                    
                    if (currentElement == arr[currI])
                    {
                        currentCounter++;
                    }
                    else
                    {
                        break;
                    }
                }
                if (currentCounter > bestCount)
                {
                    bestIndex = i;
                    bestCount = currentCounter;
                }
            }
                string result = "";
                for (int i = 0; i < bestCount; i++)
                {
                    result += arr[bestIndex] + " ";
                }
                Console.WriteLine(result);
            
        }
    }
}
