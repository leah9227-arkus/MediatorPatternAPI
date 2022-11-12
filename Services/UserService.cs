using MediatorPatternAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediatorPatternAPI.Services
{
    public class UserService : IUserService
    {
        public async Task<User> GetUserById(int userId)
        {
            // TODO - retrieve data from database
            var user = new User()
            {
                Id = userId,
                Age = userId,
                FirstName = "First name from service",
                LastName = "Last name from service"
            };

            return user;
        }

        public async Task<ICollection<User>> ListUsers()
        {
            // TODO - retrieve data from database
            var userList = new List<User>()
            {
                new User()
                {
                    Id = 1,
                    Age = 1,
                    FirstName = "Panchito from micro service",
                    LastName = "Dominguez"
                },
                new User()
                {
                    Id = 2,
                    Age = 2,
                    FirstName = "Panchito 2 we from micro service",
                    LastName = "Martinez"
                }
            };

            return userList;
        }

        public async Task<User> CreateUser(User user)
        {
            // TODO - send data to database
            user.LastName += " from service xd";
            user.Id = DateTime.Now.Millisecond;
            return user;
        }
    }
}
