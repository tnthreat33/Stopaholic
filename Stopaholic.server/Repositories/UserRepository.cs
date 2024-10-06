using Stopaholic.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace Stopaholic.Server.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _context;

        public UserRepository(ApplicationDbContext context)
        {
            {
                _context = context;
            }

        }
        public async Task AddUserAsync(User User)
        {
            await _context.Users.AddAsync(User);
            await _context.SaveChangesAsync();
        }
    }
}