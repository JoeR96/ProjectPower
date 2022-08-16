using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ProjectPower.Areas.UserAccounts.Services;
using ProjectPower.Areas.UserAccounts.Services.Interfaces;
using ProjectPowerData.Folder.Models;
using ProjectPowerWebApi.Controllers.Areas.Login.TokenResources;

namespace ProjectPowerWebApi.Controllers.Areas.Users
{
    [ApiController]
    [Route("[controller]")]
    public class UserAccountsController : ControllerBase
    {
        private readonly ILogger<UserAccountsController> _logger;
        private readonly IUserAccountService _userAccountService;

        public UserAccountsController(IUserAccountService userAccountService, ILogger<UserAccountsController> logger, IMapper mapper)
        {
            _logger = logger;
            _userAccountService = userAccountService;
        }
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public void CreateUserAsync([FromBody] CreateUserAccountModel userCredentials)
        {
            User user = new User()
            {
                UserName = userCredentials.UserName,
                Email = userCredentials.Email,
                Password = userCredentials.Password,
            };

            _userAccountService.CreateUserAccountAsync(user);
        }

    }
}
