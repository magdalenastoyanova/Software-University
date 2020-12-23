using System;
using System.Linq;

namespace finalExam7_12_19g1
{
    class Program
    {
        static void Main(string[] args)
        {

            string email = Console.ReadLine();

            string command = "";

            while ((command = Console.ReadLine()) != "Complete")
            {

                string[] commArgs = command.Split().ToArray();

                switch (commArgs[0])
                {
                    case "Make":

                        if (commArgs[1] == "Upper")
                        {
                            email = email.ToUpper();
                        }
                        else if (commArgs[1] == "Lower")
                        {
                            email = email.ToLower();
                        }
                        Console.WriteLine(email);
                        break;

                    case "GetDomain":
                        int count = int.Parse(commArgs[1]);

                        if (count < email.Length && count >= 0)
                        {
                            Console.WriteLine(email.Substring(email.Length - count));
                        }
                        else
                        {
                            Console.WriteLine(email);
                        }
                        break;

                    case "GetUsername":
                        if (email.Contains('@'))
                        {
                            int indexOfAt = email.IndexOf('@');
                            string username = email.Substring(0, indexOfAt);
                            Console.WriteLine(username);
                        }
                        else
                        {
                            Console.WriteLine($"The email {email} doesn't contain the @ symbol.");
                        }
                        break;

                    case "Replace":
                        char currentCh = char.Parse(commArgs[1]);
                        email = email.Replace(currentCh, '-');
                        Console.WriteLine(email);
                        break;

                    case "Encrypt":
                        for (int i = 0; i < email.Length; i++)
                        {
                            char currSumbol = email[i];
                            Console.Write((int)currSumbol + " ");
                        }
                        Console.WriteLine();
                        break;
                }

            }

        }
    }
}
