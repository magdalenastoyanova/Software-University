using System;

namespace finalExam3_08_19g1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string command = Console.ReadLine();

            while (command != "End")
            {
                var split = command.Split();
                string action = split[0];

                switch (action)
                {
                    case "Translate":
                        char replace = char.Parse(split[1]);
                        char replacement = char.Parse(split[2]);
                        input = input.Replace(replace, replacement);
                        Console.WriteLine(input);
                        break;
                    case "Includes":
                        string isInclude = split[1];
                        if (input.Contains(isInclude))
                        {
                            Console.WriteLine("True");
                        }
                        else
                        {
                            Console.WriteLine("False");
                        }
                        break;
                    case "Start":
                        string start = split[1];
                        if (input.StartsWith(start))
                        {
                            Console.WriteLine("True");
                        }
                        else
                        {
                            Console.WriteLine("False");
                        }
                        break;
                    case "Lowercase":
                        input = input.ToLower();
                        Console.WriteLine(input);
                        break;
                    case "FindIndex":
                        int lastIndex = input.LastIndexOf(split[1]);
                        Console.WriteLine(lastIndex);
                        break;
                    case "Remove":
                        int startIndex = int.Parse(split[1]);
                        int count = int.Parse(split[2]);

                        if (startIndex >= 0 && count > 0 && startIndex + count <= input.Length)
                        {
                            input = input.Remove(startIndex, count);
                            Console.WriteLine(input);
                        }
                        break;
                }
                command = Console.ReadLine();
            }
        }
    }
}
