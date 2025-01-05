using Stopaholic.Shared.Models;
using Stopaholic.Server.Repositories;

namespace Stopaholic.Server.Services
{
    public class MonthlyListService : IMonthlyListService
    {
        private readonly IMonthlyListRepository _monthlyListRepository;

        public MonthlyListService(IMonthlyListRepository monthlyListRepository)
        {
            _monthlyListRepository = monthlyListRepository;
        }

        public async Task AddMonthlyListAsync(MonthlyList monthlyList)
        {
            await _monthlyListRepository.AddMonthlyListAsync(monthlyList);
        }

        public async Task<List<MonthlyList>> GetMonthlyListAsync()
        {
            // Correct method name and proper return statement
            return await _monthlyListRepository.GetMonthlyListAsync();
        }
    }
}
