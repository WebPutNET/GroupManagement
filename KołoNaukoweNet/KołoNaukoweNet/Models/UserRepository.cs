using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KołoNaukoweNet.Models
{
    public static class UserRepository
    {

        private static ICollection<User> users;

        public static ICollection<User> CreateUserRepository()
        {
            users = new List<User>();

            User user = new User()
            {
                CreationDate = DateTime.Now,
                Login = "User1",
                UserName = "Karol",
                Surname = "Gwach",
                Password = "test123",
                UserId = 1
            };
            users.Add(user);

            user = new User()
            {
                CreationDate = DateTime.Now.Subtract(TimeSpan.FromDays(1)),
                Login = "Administrator",
                UserName = "Rafał",
                Surname = "Tkaczyk",
                Password = "admin",
                UserId = 2
            };

            users.Add(user);

            user = new User()
            {
                UserId = 3,
                CreationDate = DateTime.Now.Subtract(TimeSpan.FromHours(5)),
                Login = "Tester",
                UserName = "Bartosz",
                Surname = "Drwal",
                Password = "test"
            };
            users.Add(user);

            return users;

        }

        public static void AddUser(User user)
        {
            users.Add(user);
        }

        public static ICollection<User> GetUserCollection()
        {
            return users;
        }

    }
}