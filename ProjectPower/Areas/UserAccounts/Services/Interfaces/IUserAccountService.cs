using ProjectPower.Areas.UserAccounts.Communication;
using ProjectPowerData.Folder.Models;

namespace ProjectPower.Areas.UserAccounts.Services.Interfaces
{
    public interface IUserAccountService
    {
        Task<User> FindByEmailAsync(string email);
        Task<CreateUserResponse> CreateUserAccountAsync(ProjectPowerData.Folder.Models.User userAccount, params ApplicationRole[] userRoles);

    }
}
