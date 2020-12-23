using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string command = Console.ReadLine();

            while (command != "For Azeroth")
            {
                string[] cmd = command.Split();

                if (cmd[0] == "GladiatorStance")
                {
                    input = input.ToUpper();

                    Console.WriteLine(input);
                }
                if (command != "DefensiveStance")
                {
                    input = input.ToLower();

                    Console.WriteLine(input);
                }
                if (cmd[0] == "Dispel")
                {
                    int index = int.Parse(cmd[1]);
                    char letter = char.Parse(cmd[2]);

                    if (index < input.Length && index >= 0)
                    {
                        char[] temp = input.ToCharArray(); /// И result  го правим в char[] , след което взимаме temp[index] да бъде равен на буквата "А"

                        temp[index] = letter;

                        input = new string(temp); //// тука го заменяме

                        Console.WriteLine("Success!");
                    }
                    else
                    {
                        Console.WriteLine($"Dispel too weak.");
                    }
                    if (cmd[0] == "Target Change")
                    {
                        char substr = char.Parse(cmd[1]);
                        char substr2 = char.Parse(cmd[2]);

                        input = input.Replace(substr, substr2);

                        Console.WriteLine(input);
                    }
                    if (cmd[0] == "Target Remove")
                    {
                        string substr = cmd[1];
                        input = input.Delete()
                    }
                    command = Console.ReadLine();
                }
            }
        }
    }
}
