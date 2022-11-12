using MediatorPatternAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediatorPatternAPI.Services
{
    public interface IUserService
    {
        public Task<ICollection<User>> ListUsers();
        public Task<User> GetUserById(int userId);
        public Task<User> CreateUser(User user);
    }
}
