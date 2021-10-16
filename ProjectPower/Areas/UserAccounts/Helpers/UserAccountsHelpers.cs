using ProjectPowerData.Folder.Models;

namespace ProjectPower.Areas.UserAccounts.Helpers
{
    class UserAccountsHelpers
    {
        public static string HashPassword(string password)
        {
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);
            return hashedPassword;
        }

        public static bool VerifyPassword(string password, string passwordHash)
        {
            return BCrypt.Net.BCrypt.Verify(password, passwordHash);
        }

        public static void UserLogin(ProjectPowerData.Folder.Models.UserAccounts userAccount)
        {
            var hashedPw = HashPassword(userAccount.Password); 

            if(VerifyPassword(userAccount.Password,hashedPw))
            {
                //login
            }
        }
    }
}
