
using System;
using System.Linq;

namespace finalExam9_08_19
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string command = Console.ReadLine();

            while (command != "Sign up")
            {
                string[] cmd = command.Split();

                if (cmd[0] == "Case")
                {
                    string position = cmd[1];
                    if (position == "upper")
                    {
                        username = username.ToUpper();
                    }
                    else if (position == "lower")
                    {
                        username = username.ToLower();
                    }
                    Console.WriteLine(username);
                }
                if (cmd[0] == "Reverse")
                {
                    int start = int.Parse(cmd[1]);
                    int stop = int.Parse(cmd[2]); 

                    if (start >= 0 && stop <= username.Length && stop > start)
                    {
                        string word = username.Substring(start, (stop - start) + 1);

                        Console.WriteLine(string.Join("", word.Reverse()));
                    }
                }
                if (cmd[0] == "Cut")
                {
                    string substring = cmd[1];
                  
                    if (username.Contains(substring))
                    {
                      string result = username.Remove(username.IndexOf(substring), substring.Length);

                        Console.WriteLine(result);
                    }
                    else
                    {
                        Console.WriteLine($"The word {username} doesn't contain {substring}.");
                    }
                }
                if (cmd[0] == "Replace")
                {
                    char ch = char.Parse(cmd[1]);

                  username = username.Replace(ch, '*');
                   
                    Console.WriteLine(username);
                }
                if (cmd[0] == "Check")
                {
                    char ch = char.Parse(cmd[1]);

                    if (username.Contains(ch))
                    {
                        Console.WriteLine("Valid");
                    }
                    else
                    {
                        Console.WriteLine($"Your username must contain {ch}.");
                    }
                }
                command = Console.ReadLine();
                for (int i = 0; i < to; i++)
                {

                }
            }
            
        }
        
    }
}
