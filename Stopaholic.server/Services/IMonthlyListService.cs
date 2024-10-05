using Stopaholic.Shared.Models;

namespace Stopaholic.Server.Services
{
    public interface IMonthlyListService
    {
        Task AddMonthlyListAsync(MonthlyList monthlyList);
    }
}
