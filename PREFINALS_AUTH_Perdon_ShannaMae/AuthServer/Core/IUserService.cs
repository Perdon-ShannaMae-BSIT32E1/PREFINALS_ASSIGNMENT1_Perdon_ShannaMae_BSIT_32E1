using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthServer.Core
{
    public interface IUserService
    {
        Task<User> RegisterUserAsync(string username, string password);
        Task<User> AuthenticateUserAsync(string username, string password);
        Task<bool> ChangePasswordAsync(string username, string newPassword);

    }
}

