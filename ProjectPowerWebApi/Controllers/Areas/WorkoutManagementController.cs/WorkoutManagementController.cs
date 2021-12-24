using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProjectPower.Areas.A2S_Program.Models.A2SWorkoutModels;
using ProjectPower.Areas.WorkoutCreation.Models;
using ProjectPower.Areas.WorkoutCreation.Services;

namespace ProjectPowerWebApi.Controllers.Areas.WorkoutManagementController.cs
{
    [ApiController]
    [Route("WorkoutCreation")]
    public class WorkoutManagementController : ControllerBase
    {
        private readonly ILogger<WorkoutManagementController> _logger;
        private readonly IWorkoutManagementService _service;

        public WorkoutManagementController(IWorkoutManagementService service)
        {
            _service = service;
        }

        [HttpPost("CreateWorkout")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public ActionResult CreateWorkout(CreateWorkoutMasterTemplateModel model)
        {
            try
            {
                _service.CreateWorkout(model);
                return NoContent();
            }
            catch(Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpGet("DailyWorkout")]
        [HttpGet("{username}/{week}/{day}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult DailyWorkout(string username, int week, int day)
        {
            try
            {
                _service.GetDailyWorkout(username,week,day);
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
