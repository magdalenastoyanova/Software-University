using System;
using System.Text;

namespace repeatString
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            string result = NewText(text, n);

            Console.WriteLine(result);
        }
        static string NewText(string text, int n)
        {
            StringBuilder result = new StringBuilder();
            
            for (int i = 0; i < n; i++)
            {
                result.Append(text);
            }
            return result.ToString();
        }
    }
}
