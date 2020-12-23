using System;
using System.Collections.Generic;
using System.Linq;

namespace _3.Followers
{
    class Program
    {
        static void Main(string[] args)
        {
            string commands = null;
            // <users,comments count>
            var users = new Dictionary<string, int>();
            var usersComments = new Dictionary<string, int>();

            while ((commands = Console.ReadLine()) != "Log out")
            {
                var command = commands.Split(": ", 2).ToArray();
                var action = command[0];
                var user = command[1];

                switch (action)
                {
                    // New follower: {username}
                    case "New follower":
                        if (users.ContainsKey(user))
                            continue;

                        users[user] = 0;
                        usersComments[user] = 0;
                        user(user)  = 0
                        break;
                    // Like: {username}: {count}
                    case "Like":
                        int.TryParse(user.Split(": ")[1], out int count);
                        if (!users.ContainsKey(user.Split(": ")[0]))
                        {
                            users[user.Split(": ")[0]] = count;
                            usersComments[user.Split(": ")[0]] = 0;
                        }
                        else
                            users[user.Split(": ")[0]] += count;
                        break;
                    // Comment: {username}
                    case "Comment":
                        if (!usersComments.ContainsKey(user))
                        {
                            usersComments[user] = 1;
                            users[user] = 0;
                        }
                        else
                            usersComments[user]++;
                        break;
                    // Blocked: {username}
                    case "Blocked":
                        if (!users.ContainsKey(user))
                            Console.WriteLine($"{user} doesn't exist.");
                        else
                        {
                            users.Remove(user);
                            usersComments.Remove(user);
                        }
                        break;
                        for (int i = 0; i < users; i++)
                        {

                        }
                }
            }

            Console.WriteLine($"{users.Count()} followers");
            Console.WriteLine(string.Join($"{Environment.NewLine}", users
                .OrderByDescending(x => x.Value)
                .ThenBy(x => x.Key)
                .Select(x => $"{x.Key}: {x.Value + usersComments[x.Key]}")));
        }
        }
    }
