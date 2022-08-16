using ProjectPower.Areas.UserAccounts.Communication;
using ProjectPowerData.Folder.Models;

namespace ProjectPower.Areas.UserAccounts.Services.Interfaces
{
    public interface ITokenHandlerService
    {
        AccessToken CreateAccessToken(User user);
        RefreshToken TakeRefreshToken(string token);
        void RevokeRefreshToken(string token);
    }
}
