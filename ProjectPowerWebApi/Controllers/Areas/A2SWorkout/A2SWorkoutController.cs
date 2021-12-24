using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProjectPower.Areas.A2S_Program.Models.A2SWorkoutModels;
using ProjectPower.Areas.A2S_Program.Service.Interfaces;
using ProjectPower.Areas.WorkoutCreation.Models;
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


    }
}
