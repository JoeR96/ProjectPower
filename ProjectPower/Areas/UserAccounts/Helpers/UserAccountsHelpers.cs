using Newtonsoft.Json.Linq;
using ProjectPowerData.Folder.Models;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPower.Areas.UserAccounts.Helpers
{
    public static class UserAccountsHelpers
    {

        
        public static string HashPassword(string password)
        {

            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);
            return hashedPassword;
        }



        public static bool UserLogin(UserAccounts.Models.UserAccounts.UserAccountLoginModel userAccount, ProjectPowerData.Folder.Models.UserAccounts dbEntity)
        {
            
            if (BCrypt.Net.BCrypt.Verify(userAccount.Password, dbEntity.Password))
            {                      
                return true;

            }
            else
            {
                return false;
            }
        }

    }
}
