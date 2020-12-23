using System;

namespace charactersInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            char start = char.Parse(Console.ReadLine());
            char stop = char.Parse(Console.ReadLine());

            PrintTheCharBetweenTwoChars(start, stop);

        }
          static void PrintTheCharBetweenTwoChars( char firstCharacter, char secondCharacter)
        {
            int startCharacter = Math.Min(firstCharacter, secondCharacter);
            int endCharacter = Math.Max(firstCharacter, secondCharacter);
            for (int i = ++startCharacter; i < endCharacter; i++)
            {
                Console.Write((char)i + " ");
            }
           
            Console.WriteLine();
            
        }
    }
}
