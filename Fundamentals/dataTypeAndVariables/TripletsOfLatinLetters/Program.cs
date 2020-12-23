using System;

namespace TripletsOfLatinLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char endLetter = (char)(97 + n);
            for (char a = 'a'; a < endLetter; a++)
            {
                for (char b = 'a'; b < endLetter; b++)
                {
                    for (char c = 'a'; c < endLetter; c++)
                    {
                        Console.WriteLine($"{a}{b}{c}");
                    }
                }
               
            }
            
        }
    }
}
