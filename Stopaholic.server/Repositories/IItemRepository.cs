using Stopaholic.Shared.Models;

namespace Stopaholic.Server.Repositories
{
    public interface IItemRepository
    {
        Task AddItemAsync(Item Item);
    }
}
