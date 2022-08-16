using ProjectPower.Areas.UserAccounts.Services.Interfaces;

namespace ProjectPower.Areas.UserAccounts.Services
{
    public class PasswordHasherService : IPasswordHasherService
    {
        public string HashPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }
        public bool PasswordMatches(string providedPassword, string passwordHash)
        {
            return BCrypt.Net.BCrypt.Verify(providedPassword, passwordHash);
        }
    }
}
