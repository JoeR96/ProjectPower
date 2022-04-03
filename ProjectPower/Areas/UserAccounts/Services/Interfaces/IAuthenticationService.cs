using ProjectPower.Areas.UserAccounts.Communication;
using System.Threading.Tasks;

namespace ProjectPower.Areas.UserAccounts.Services.Interfaces
{
    public interface IAuthenticationService
    {
        Task<TokenResponse> CreateAccessTokenAsync(string email, string password);
        Task<TokenResponse> RefreshTokenAsync(string refreshToken, string userEmail);
        void RevokeRefreshToken(string refreshToken);
    }
}
