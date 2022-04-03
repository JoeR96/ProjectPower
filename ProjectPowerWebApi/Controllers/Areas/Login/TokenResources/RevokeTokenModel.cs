using System.ComponentModel.DataAnnotations;

namespace ProjectPowerWebApi.Controllers.Areas.Login.TokenResources
{
    public class RevokeTokenModel
    {
        [Required]
        public string Token { get; set; }
    }
}
