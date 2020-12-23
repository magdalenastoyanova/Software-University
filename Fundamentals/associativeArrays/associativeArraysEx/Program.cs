using System;
using System.Collections.Generic;

namespace associativeArraysEx
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            Dictionary<char, int> lettersCount = new Dictionary<char, int>();

            for (int i = 0; i < word.Length; i++)
            {
                char letter = word[i];
              
                if (letter != ' ')
                {
                    if (!lettersCount.ContainsKey(letter))
                    {
                        lettersCount[letter] = 1;
                    }
                    else
                    {
                        lettersCount[letter]++;
                    }
                }
            }
            foreach (var kvp in lettersCount)
            {
                char key = kvp.Key;
                int value = kvp.Value;
               
                Console.WriteLine($"{key} -> {value}");
            }
        }
    }
}
