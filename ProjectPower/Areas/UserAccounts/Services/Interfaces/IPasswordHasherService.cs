namespace ProjectPower.Areas.UserAccounts.Services.Interfaces
{
    public interface IPasswordHasherService
    {
        string HashPassword(string password);
        bool PasswordMatches(string providedPassword, string passwordHash);
    }
}
