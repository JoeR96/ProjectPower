using System.ComponentModel.DataAnnotations;

namespace ProjectPowerWebApi.Controllers.Areas.Login.TokenResources
{
    public class CreateUserAccountModel
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        [StringLength(255)]
        public string Email { get; set; }

        [Required]
        [StringLength(32)]
        public string Password { get; set; }
        [Required]
        [StringLength(12)]
        public string UserName { get; set; }
    }
}
