using System;

namespace caminoFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            string input = null;
            int bestCount = 0;
            int bestSum = 0;
            int bestBeginIndex = 0;
            string bestSequence = "";
            int counter = 0;
            int bestCounter = 0;

            while ((input = Console.ReadLine()) != "Clone them")
            {
                string sequence = input.Replace("!", "");
                string[] dnaParts = sequence.Split("0", StringSplitOptions.RemoveEmptyEntries);
                int count = 0;
                int sum = 0;
                string bestSubsequence = "";
                counter++;

                foreach (string dnaPart in dnaParts)
                {
                    if (dnaPart.Length > count)
                    {
                        count = dnaPart.Length;
                        bestSubsequence = dnaPart;
                    }
                    sum += dnaPart.Length;
                }
                int beginIndex = sequence.IndexOf(bestSubsequence);

                if (count > bestCount ||
                    count == bestCount && beginIndex < bestBeginIndex||
                    count == bestCount && beginIndex == bestBeginIndex && sum>bestSum||
                    counter == 1)
                {
                    bestCount = count;
                    bestSequence = sequence;
                    bestBeginIndex = beginIndex;
                    bestSum = sum;
                    bestCounter = counter;
                }
                char[] arr1 = bestSequence.ToCharArray();
            }

            char[] arr1 = bestSequence.ToCharArray();

            Console.WriteLine($"Best DNA sample {bestCounter} with sum: {bestSum}.");
            Console.WriteLine(string.Join(" ", arr1));
        }
        
    }
}
