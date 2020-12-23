using System;
using System.Text.RegularExpressions;

namespace _02._Fancy_Barcodes
{
    class Program
    {
        static void Main(string[] args)
        {
            int howMany = int.Parse(Console.ReadLine());
            string pattern = @"@#+([A-Z][A-Za-z\d]{4,}[A-Z])@#+";
            for (int i = 0; i < howMany; i++)
            {
                string input = Console.ReadLine();
                Match barcode = Regex.Match(input, pattern);
                string productGroup = "00";
                bool checker = false;
                if (barcode.Success)
                {
                    string product = barcode.Value;
                    for (int j = 0; j < product.Length; j++)
                    {
                        char letter = product[j];
                        if (char.IsDigit(letter))
                        {
                            if (!checker)
                            {
                                productGroup = string.Empty;
                            }
                            checker = true;
                            productGroup += letter;
                        }
                    }
                    Console.WriteLine($"Product group: {productGroup}");
                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }

            }
        }
    }
}
    