using Microsoft.AspNetCore.Mvc;
using Stopaholic.Shared.Models;
using Stopaholic.Server.Services;

namespace Stopaholic.Server.Controllers
{
    [ApiController]
    [Route("/login")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _UserService;

        public UserController(IUserService UserService)
        {
            _UserService = UserService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser(User User)
        {
            if (User == null)
            {
                return BadRequest("Invalid data.");
            }

            await _UserService.AddUserAsync(User);
            return Ok(User);
        }
    }
}
