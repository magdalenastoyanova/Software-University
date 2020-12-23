using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _02._Song_Encryption
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"([A-Z][a-z\ \']+):([A-Z ]+)";
            var enterCommand = Console.ReadLine();
            var builder = new StringBuilder();
            while (enterCommand != "end")
            {
                Match match = Regex.Match(enterCommand, pattern);
                var splitText = enterCommand.Split(":");
                if (match.Groups[1].ToString() == splitText[0] && match.Groups[2].ToString() == splitText[1])
                {
                    foreach (char item in enterCommand)
                    {
                        int newItemValue = item + splitText[0].Length;
                        if (item == 58)
                        {
                            newItemValue = 64;
                        }
                        else if (item == 32 || item == 39)
                        {
                            newItemValue = item;
                        }
                        else if (newItemValue > 90 && item > 64 && item < 91)
                        {
                            int difference = newItemValue - 90;
                            newItemValue = 64 + difference;
                        }
                        else if (newItemValue > 122 && item > 96 && item < 123)
                        {
                            int difference = newItemValue - 122;
                            newItemValue = 96 + difference;
                        }
                        builder.Append(char.ConvertFromUtf32(newItemValue));
                    }
                    Console.WriteLine("Successful encryption: " + builder);
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
                enterCommand = Console.ReadLine();
                builder = new StringBuilder();
            }
        }
    }
}
