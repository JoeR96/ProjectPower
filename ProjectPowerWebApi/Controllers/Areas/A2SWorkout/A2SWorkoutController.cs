using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProjectPower.Areas.A2S_Program.Models.A2SWorkoutModels;
using ProjectPower.Areas.A2S_Program.Service.Interfaces;
using ProjectPower.Areas.UserAccounts.Models.UserAccounts;
using ProjectPower.Areas.UserAccounts.Services.Interfaces;
using System;
using System.Collections.Generic;

namespace ProjectPowerWebApi.Controllers.Areas.Users
{
    [ApiController]
    [Route("[controller]")]
    public class A2SWorkoutController : ControllerBase
    {
        private readonly ILogger<A2SWorkoutController> _logger;
        private readonly IA2SWorkoutService _service;

        public A2SWorkoutController(IA2SWorkoutService service, ILogger<A2SWorkoutController> logger)
        {
            _logger = logger;
            _service = service;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<IEnumerable<ShowA2SWorkoutModel>> Index([FromQuery] A2SWorkoutSearchModel search)
        {
            var response = _service.GetIndexModel(search);

            return Ok(response);
        }

        [HttpGet("Count")]
        public ActionResult<ShowA2SWorkoutModel> Show(long id)
        {
            var response = _service.GetShowModel(id);

            if (response == null)
            {
                return BadRequest();
            }
            else
            {
                return response;
            }
        }

        [HttpGet("{id:long}/Edit")]
        public ActionResult<UpdateA2SAmrapResultModel> Edit(long id)
        {
            var response = _service.GetUpdateModel(id);

            if(response == null)
            {
                return BadRequest();
            }
            else
            {
                return response;
            }
        }

        [HttpPut]
        public ActionResult Update(UpdateA2SAmrapResultModel model)
        {
            try
            {
                _service.SaveUpdateModel( model);
                return Ok();
            }
            catch (KeyNotFoundException)
            {
                return NotFound();
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
        public ActionResult<ShowA2SWorkoutModel> Create(CreateA2SWorkoutModel model)
        {
            try
            {
                var response = _service.SaveCreateModel(model);
                return CreatedAtAction(nameof(A2SWorkoutController.Show), new { id = response.Id }, response);
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }
    }
}
