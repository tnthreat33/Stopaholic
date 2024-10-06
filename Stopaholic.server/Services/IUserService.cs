using Stopaholic.Shared.Models;

namespace Stopaholic.Server.Services
{
    public interface IUserService
    {
        Task AddUserAsync(User User);
    }
}
