using Stopaholic.Shared.Models;
using Stopaholic.Server.Repositories;
using Microsoft.EntityFrameworkCore;

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
        public async Task<List<MonthlyList>> GetAllMonthlyListAsync()
        {
            await _monthlyListRepository.GetMonthlyListAsync();
        }
    }
}
