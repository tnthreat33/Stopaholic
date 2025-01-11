using Stopaholic.Shared.Models;

namespace Stopaholic.Server.Repositories
{
    public interface IItemRepository
    {
        Task AddItemAsync(Item Item);
        Task<List<Item>> GetItemsAsync(int userId);
    }
}
