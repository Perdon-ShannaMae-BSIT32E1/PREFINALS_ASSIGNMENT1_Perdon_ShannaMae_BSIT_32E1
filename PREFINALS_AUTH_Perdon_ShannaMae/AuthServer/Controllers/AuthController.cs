using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Threading.Tasks;
using AuthServer.Core
Using AuthServer.Models;

namespace AuthServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IUserService _userService
        public AuthController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("register")]
        public async Task<IActionResult> RegisterUser([FromBody] UserRegistrationModel Models)
        {
            await _userService.RegisterAsync(Models.Username, Models.NewPassword);
            return Ok("User registered successfully");
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] UserLoginModel Models)
        {
            var user = await _userService.AuthenticateUserAsync(Models.Username, Models.Password);
            if (user == null)
                return BadRequest("Invalid username or password");
            else
                return Ok("Login Successful");
        }

        [HttpPost("changepassword")]
        public async Task<IActionResult> ChangePassword([FromBody] ChangePasswordModel Models)
        {
            var success = await _userService.ChangePasswordAsync(Models.Username, Models.NewPassword);
            if (success)
                return Ok("success");
            else
                return BadRequest("Failed to change password");
        }
    }
}