using ProjectPower.Areas.UserAccounts.Services;
using ProjectPowerData.Folder.Models;

namespace ProjectPower.Repositories.Interfaces
{
    public interface IUserAccountRepository
    {
        Task AddAsync(User user, ApplicationRole[] userRoles);
        Task<User> FindByEmailAsync(string email);
    }
}
