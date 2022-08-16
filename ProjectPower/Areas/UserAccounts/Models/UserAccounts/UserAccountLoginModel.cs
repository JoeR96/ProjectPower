using System.ComponentModel.DataAnnotations;

namespace ProjectPower.Areas.UserAccounts.Models.UserAccounts
{
    public class UserAccountLoginModel
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        [StringLength(255)]
        public string EmailAddress { get; set; }
        [Required]
        [StringLength(32)]
        public string Password { get; set; }

    }
}
