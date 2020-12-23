using System;
using System.Globalization;

namespace objectAndClassesLab
{
    class Program
    {
        static void Main(string[] args)
        {
            string dateAsString = Console.ReadLine();
            DateTime date = DateTime.ParseExact(dateAsString, "d-M-yyyy", CultureInfo.InvariantCulture);
            Console.WriteLine(date.DayOfWeek);
        }
    }
}
