
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProjectPower.Areas.UserAccounts.Models.UserAccounts
{
    public class UserAccountLoginModel : IValidatableObject
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (Password.Length < 5)
            {
                yield return new ValidationResult("Password must be greater than 6 characters", new List<string> { nameof(Password) });
            }
        }
    }
}
