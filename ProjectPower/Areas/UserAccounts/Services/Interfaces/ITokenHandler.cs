using ProjectPower.Areas.UserAccounts.Communication;
using ProjectPowerData.Folder.Models;

namespace ProjectPower.Areas.UserAccounts.Services.Interfaces
{
    public interface ITokenHandler
    {
        AccessToken CreateAccessToken(User user);
        RefreshToken TakeRefreshToken(string token);
        void RevokeRefreshToken(string token);
    }
}
