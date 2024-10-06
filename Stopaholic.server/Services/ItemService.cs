using Stopaholic.Shared.Models;
using Stopaholic.Server.Repositories;

namespace Stopaholic.Server.Services
{
    public class ItemService : IItemService
    {
        private readonly IItemRepository _ItemRepository;

        public ItemService(IItemRepository ItemRepository)
        {
            _ItemRepository = ItemRepository;
        }

        public async Task AddItemAsync(Item Item)
        {

            await _ItemRepository.AddItemAsync(Item);
        }
    }
}
