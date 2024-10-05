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
    }
}
