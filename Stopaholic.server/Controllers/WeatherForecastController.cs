using Microsoft.AspNetCore.Mvc;

namespace Stopaholic.server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MonthlyListController : ControllerBase
    {
       

        private readonly ILogger<MonthlyListController> _logger;

        public MonthlyListController(ILogger<MonthlyListController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
        }
    }
}
