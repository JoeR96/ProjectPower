using AutoMapper;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProjectPower.Areas.UserAccounts.Models.UserAccounts;
using ProjectPower.Areas.UserAccounts.Services;
using ProjectPower.Areas.UserAccounts.Services.Interfaces;
using ProjectPowerData.Folder.Models;
using ProjectPowerWebApi.Controllers.Areas.Login.TokenResources;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProjectPowerWebApi.Controllers.Areas.Users
{
    [ApiController]
    [Route("[controller]")]
    public class UserAccountsController : ControllerBase
    {
        private readonly ILogger<UserAccountsController> _logger;
        private readonly IUserAccountService _userAccountService;
        private readonly IMapper _mapper;

        public UserAccountsController(IUserAccountService userAccountService, ILogger<UserAccountsController> logger, IMapper mapper)
        {
            _logger = logger;
            _userAccountService = userAccountService;
            _mapper = mapper;
        }
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<IActionResult> CreateUserAsync([FromBody] CreateUserAccountModel userCredentials)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                var user = _mapper.Map<CreateUserAccountModel, User>(userCredentials);
                var response = await _userAccountService.CreateUserAccountAsync(user, ApplicationRole.Common);
                if (!response.Success)
                {
                    return BadRequest(response.Message);
                }

                var userResource = _mapper.Map<User, UserResourceModel>(response.User);
                return Ok(userResource);
            }
            catch(Exception ex)
            {
                throw ex;
            }
            
        }

    }
}
