using ProjectPower.Areas.UserAccounts.Services;
using ProjectPowerData.Folder.Models;
using System.Threading.Tasks;

namespace ProjectPower.Repositories.Interfaces
{
    public interface IUserAccountRepository
    {
        Task AddAsync(User user, ApplicationRole[] userRoles);
        Task<User> FindByEmailAsync(string email);
    }
}
