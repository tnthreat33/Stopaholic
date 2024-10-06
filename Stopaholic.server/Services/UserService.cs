using Stopaholic.Shared.Models;
using Stopaholic.Server.Repositories;

namespace Stopaholic.Server.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _UserRepository;

        public UserService(IUserRepository UserRepository)
        {
            _UserRepository = UserRepository;
        }

        public async Task AddUserAsync(User User)
        {

            await _UserRepository.AddUserAsync(User);
        }
    }
}
