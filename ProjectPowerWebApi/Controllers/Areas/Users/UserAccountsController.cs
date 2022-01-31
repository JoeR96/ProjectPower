using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProjectPower.Areas.UserAccounts.Models.UserAccounts;
using ProjectPower.Areas.UserAccounts.Services.Interfaces;
using System;
using System.Collections.Generic;

namespace ProjectPowerWebApi.Controllers.Areas.Users
{
    [ApiController]
    [Route("[controller]")]
    public class UserAccountsController : ControllerBase
    {
        private readonly ILogger<UserAccountsController> _logger;
        private readonly IUserAccountService _service;

        public UserAccountsController(IUserAccountService service, ILogger<UserAccountsController> logger)
        {
            _logger = logger;
            _service = service;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<IEnumerable<ShowUserAccountModel>> Index([FromQuery] UserAccountSearchModel search)
        {
            var response = _service.GetIndexModel(search);

            return Ok(response);
        }

        [HttpGet("Username")]
        public ActionResult<ShowUserAccountModel> Show(string username)
        {
            var response = _service.GetShowModelByUsername(username);

            if (response == null)
            {
                return BadRequest();
            }
            else
            {
                return response;
            }
        }



        [HttpDelete("{id:long}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public ActionResult Delete(long id)
        {
            try
            {
                _service.Delete(id);
                return NoContent();
            }
            catch (KeyNotFoundException)
            {
                return NotFound();
            }
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public ActionResult<ShowUserAccountModel> Create(CreateUserAccountModel model)
        {
            try
            {
                var response = _service.SaveCreateModel(model);
                return CreatedAtAction(nameof(UserAccountsController.Show), response);
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }
    }
}
