using System;
using System.Text;

namespace textFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string text = Console.ReadLine();

         text = text.Replace(word, new string('*', word.Length));

            Console.WriteLine(text);
        }
    }
}
