
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Text;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] bigNumber = Console.ReadLine().ToCharArray();
            int number = int.Parse(Console.ReadLine());
            int reminder = 0;
            if (number == 0)
            {
                Console.WriteLine(0);
                return;
            }

            System.Text.StringBuilder sb = new StringBuilder();
            for (int i = bigNumber.Length - 1; i >= 0; i--)
            {
                char currentCh = bigNumber[i];
                int currentInt = (int)char.GetNumericValue(currentCh);
                int result = currentInt * number + reminder;
                int digit = result % 10;
                reminder = result / 10;
                sb.Append(digit);

            }
            if (reminder != 0)
            {
                sb.Append(reminder);
            }
            List<char> end = sb.ToString().Reverse().ToList();
            for (int i = 0; i < end.Count; i++)
            {
                if (end[0] == '0')
                {
                    end.RemoveAt(0);
                    i = i - 1;
                }
            }

            Console.WriteLine(string.Join("", end));
        }
    }
}
