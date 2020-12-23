using System;

namespace vowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine().ToLower();
            int vowelCount = 0;

            for (int i = 0; i < text.Length; i++)
            {
                char symbol = text[i];

                if (isVowel(symbol))
                {
                    vowelCount++;
                }
            }
            Console.WriteLine(vowelCount);
        }
        static bool isVowel(char letter)
        {
            return letter == 'a' || letter == 'o' || letter == 'i' ||
                   letter == 'u' || letter == 'e' || letter == 'y';
        }
        // static void PrintVowel (string text)
    }
}
