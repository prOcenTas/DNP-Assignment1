using System;
using System.Collections.Generic;
using System.Linq;
using Models;

namespace Assignment1.Data.Impl
{
    public class InMemoryUserService : IUserService
    {
        private List<User> users;

        public InMemoryUserService()
        {
            users = new[]
            {
                new User
                {
                    UserName = "Faustas",
                    Role = "Manager",
                    Password = "123456",
                },
                new User
                {
                    UserName = "Alex",
                    Role = "Manager",
                    Password = "654321",

                },
                new User
                {
                    UserName = "Bogdan",
                    Role = "User",
                    Password = "1346",

                },
                new User
                {
                    UserName = "Stas",
                    Role = "User",
                    Password = "123",

                },

            }.ToList();
        }
        
        public User ValidateUser(string userName, string password)
        {
            User first = users.FirstOrDefault(user => user.UserName.Equals(userName));
            if (first == null) {
                throw new Exception("User not found");
            }

            if (!first.Password.Equals(password)) {
                throw new Exception("Incorrect password");
            }

            return first;
        }
    }
}