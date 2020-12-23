using System;

namespace middleCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            PrintMiddleCharater(text);
        }

        static void PrintMiddleCharater(string text)
        {
            if (text.Length % 2 == 0)
            {
                char firstSymbol = text[text.Length / 2 - 1];
                char secondSymbol = text[text.Length / 2 ];

                Console.WriteLine(firstSymbol + "" + secondSymbol);
            }
            else
            {
                char symbol = text[text.Length / 2];
                Console.WriteLine(symbol);
            } 
        }
    }
}
