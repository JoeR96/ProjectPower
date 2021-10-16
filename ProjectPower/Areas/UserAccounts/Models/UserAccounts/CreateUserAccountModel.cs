using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProjectPower.Areas.UserAccounts.Models.UserAccounts
{
    public class CreateUserAccountModel : IValidatableObject
    {
        [Required]
        public string UserName { get; set; }
        public string Password { get; set; }
        [EmailAddress]
        public string Email { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if(Password.Length < 6)
            {
                yield return new ValidationResult("Password must be greater than 6 characters", new List<string> { nameof(Password) });
            }
        }
    }
}
