using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthServer.Core
{
    public interface IAuthService
    {
        Task<string> GenerateJwtTokenAsync(User user);
        Task<bool> ValidateJwtTokenAsync(string token);

    }
}
