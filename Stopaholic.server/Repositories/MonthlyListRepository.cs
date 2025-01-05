using Stopaholic.Shared.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Stopaholic.Server.Repositories
{
    public class MonthlyListRepository : IMonthlyListRepository
    {
        private readonly ApplicationDbContext _context;

        public MonthlyListRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task AddMonthlyListAsync(MonthlyList monthlyList)
        {
            await _context.MonthlyWantLists.AddAsync(monthlyList); // Save new MonthlyList
            await _context.SaveChangesAsync();                     // Commit changes to database
        }

        public async Task<List<MonthlyList>> GetMonthlyListAsync()
        {
            // Fetch all MonthlyList entries from the database
            return await _context.MonthlyWantLists.ToListAsync();
        }
    }
}
