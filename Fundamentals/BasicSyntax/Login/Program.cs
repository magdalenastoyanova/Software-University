using System;

namespace Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string correnctPass = string.Empty;

            for (int i = username.Length - 1; i >= 0 ; i--)
            {
                correnctPass += username[i];
            }

            for (int i = 1; i <= 4; i++)
            {
                string password = Console.ReadLine();
                if (correnctPass == password)
                {
                    Console.WriteLine($"User {username} logged in.");
                    break;
                }
                if (i <= 3)
                {
                    Console.WriteLine("Incorrect password. Try again.");
                }
                else
                {
                    Console.WriteLine($"User {username} blocked!");
                }
            }
            
        }

    }
}
