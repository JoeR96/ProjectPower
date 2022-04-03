using ProjectPower.Areas.UserAccounts.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
