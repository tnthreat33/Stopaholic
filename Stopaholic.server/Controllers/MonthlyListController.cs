using Microsoft.AspNetCore.Mvc;
using Stopaholic.Shared.Models;
using Stopaholic.Server.Services;

namespace Stopaholic.Server.Controllers
{
    [ApiController]
    [Route("/monthly-list")]
    public class MonthlyListController : ControllerBase
    {
        private readonly IMonthlyListService _monthlyListService;

        public MonthlyListController(IMonthlyListService monthlyListService)
        {
            _monthlyListService = monthlyListService;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllMonthlyListsAysnc()
        {
            await _monthlyListService.GetMonthlyListAsync();
        }
        [HttpPost]
        public async Task<IActionResult> CreateMonthlyList(MonthlyList monthlyList)
        {
            if (monthlyList == null)
            {
                return BadRequest("Invalid data.");
            }

            await _monthlyListService.AddMonthlyListAsync(monthlyList);
            return Ok(monthlyList);
        }
    }
}
