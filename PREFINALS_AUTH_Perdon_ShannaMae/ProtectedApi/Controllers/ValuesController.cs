using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ProtectedApi.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet("user-info")]
        public IActionResult GetUserInfo()
        {
            
            var userInfo = new
            {
                Name = "Shanna Mae Perdon",
                Section = "32E1",
                Course = "BSIT"
            };

            // Fun facts about the API creator
            var funFacts = new List<string>
            {
            "Eager to learn.",
            "Prioritizing comfort in project navigation.",
            "Finding joy in exploring coding.",
            "Working on improving knowledge.",
            "Actively seeking to expand knowledge.",
            "Enjoying the thrill of discovery.",
            "Finding fulfillment despite occasional stress.",
            "Seeing challenges as opportunities for growth.",
            "Embracing the learning and discovery.",
            "Excited about project possibilities.",


            };

            var data = new
            {
                UserInfo = userInfo,
                FunFacts = funFacts
            };

            return Ok(data);
        }
    }
}
