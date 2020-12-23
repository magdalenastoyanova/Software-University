using System;
using System.Linq;

namespace finalExam04_04_2020g1
{
    class Program
    {
        static void Main(string[] args)
        {
            string rawKey = Console.ReadLine();
            string input;
            while ((input = Console.ReadLine()) != "Generate")
            {
                string[] splitCommand = input.Split(">>>").ToArray();
                var core = splitCommand[0];
                if (core == "Contains")
                {
                    if (rawKey.Contains(splitCommand[1]))
                    {
                        Console.WriteLine($"{rawKey} contains {splitCommand[1]}");
                    }
                    else
                    {
                        Console.WriteLine("Substring not found!");
                    }
                }
                else
                {
                    if (core == "Flip")
                    {
                        var peripheral = splitCommand[1];
                        int startIndex = int.Parse(splitCommand[2]);
                        int endIndex = int.Parse(splitCommand[3]);
                        string replacement;
                        string toBeReplaced;
                        if (peripheral == "Upper")
                        {
                            toBeReplaced = rawKey.Substring(startIndex, endIndex - startIndex);
                            replacement = toBeReplaced.ToUpper();
                            rawKey = rawKey.Replace(toBeReplaced, replacement);
                            Console.WriteLine(rawKey);


                        }
                        else
                        {
                            if (peripheral == "Lower")
                            {
                                toBeReplaced = rawKey.Substring(startIndex, endIndex - startIndex);
                                replacement = toBeReplaced.ToLower();
                                rawKey = rawKey.Replace(toBeReplaced, replacement);
                                Console.WriteLine(rawKey);
                            }
                        }
                    }
                    else
                    {
                        if (core == "Slice")
                        {
                            int startIndex = int.Parse(splitCommand[1]);
                            int endIndex = int.Parse(splitCommand[2]);
                            string toBeRemoved = rawKey.Substring(startIndex, (endIndex - startIndex));
                            int startPoint = rawKey.IndexOf(toBeRemoved);
                            rawKey = rawKey.Remove(startPoint, toBeRemoved.Length);
                            Console.WriteLine(rawKey);
                        }
                    }
                }

            }
            Console.WriteLine($"Your activation key is: {rawKey}");


        }
    }
}
