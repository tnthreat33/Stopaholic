using Microsoft.AspNetCore.Mvc;
using Stopaholic.Shared.Models;
using Stopaholic.Server.Services;

namespace Stopaholic.Server.Controllers
{
    [ApiController]
    [Route("/item")]
    public class ItemController : ControllerBase
    {
        private readonly IItemService _itemService;

        public ItemController(IItemService ItemService)
        {
            _itemService = ItemService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateItem(Item Item)
        {
            if (Item == null)
            {
                return BadRequest("Invalid data.");
            }

            await _itemService.AddItemAsync(Item);
            return Ok(Item);
        }
    }
}
