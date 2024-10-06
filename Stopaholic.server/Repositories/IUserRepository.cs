using Stopaholic.Shared.Models;

namespace Stopaholic.Server.Repositories
{
    public interface IUserRepository
    {
        Task AddUserAsync(User User);
    }
}
