using Stopaholic.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace Stopaholic.Server.Repositories
{
    public class ItemRepository : IItemRepository
    {
        private readonly ApplicationDbContext _context;

        public ItemRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task AddItemAsync(Item item)
        {
            await _context.WantItems.AddAsync(item);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Item>> GetItemsAsync()
        {
            // Return the list of items
            return await _context.WantItems.ToListAsync();
        }
    }
}
