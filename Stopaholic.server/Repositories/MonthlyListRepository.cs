using Stopaholic.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace Stopaholic.Server.Repositories
{
    public class MonthlyListRepository : IMonthlyListRepository
    {
        private readonly ApplicationDbContext _context;

        public MonthlyListRepository(ApplicationDbContext context)
        {
            {
                _context = context;
            }

        }
        public async Task AddMonthlyListAsync(MonthlyList monthlyList)
        {
            await _context.MonthlyWantLists.AddAsync(monthlyList);
            await _context.SaveChangesAsync();
        }
    }
}