using Stopaholic.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace Stopaholic.Server.Repositories
{
    public class ItemRepository : IItemRepository
    {
        private readonly ApplicationDbContext _context;

        public ItemRepository(ApplicationDbContext context)
        {
            {
                _context = context;
            }

        }
        public async Task AddItemAsync(Item Item)
        {
            await _context.WantItems.AddAsync(Item);
            await _context.SaveChangesAsync();
        }
    }
}