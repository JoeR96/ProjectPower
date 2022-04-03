using System.Collections.Generic;

namespace ProjectPowerWebApi.Controllers.Areas.Login.TokenResources
{
    public class UserResourceModel
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public IEnumerable<string> Roles { get; set; }
    }
}
