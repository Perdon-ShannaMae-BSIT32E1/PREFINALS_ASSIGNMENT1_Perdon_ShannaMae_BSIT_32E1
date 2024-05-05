using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthServer.Core
{
    public class DatabaseUserService : IUserService
    {
        
        public Task<User> RegisterUserAsync(string username, string password)
        {
            throw new System.NotImplementedException();
        }

        public Task<User> AuthenticateUserAsync(string username, string password)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> ChangePasswordAsync(string username, string newpassword)
        {
            throw new System.NotImplementedException();
        }
    }
}
