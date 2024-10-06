using Stopaholic.Shared.Models;

namespace Stopaholic.Server.Services
{
    public interface IItemService
    {
        Task AddItemAsync(Item Item);
    }
}
