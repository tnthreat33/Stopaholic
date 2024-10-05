using Stopaholic.Shared.Models;

namespace Stopaholic.Server.Repositories
{
    public interface IMonthlyListRepository
    {
        Task AddMonthlyListAsync(MonthlyList monthlyList);
    }
}
