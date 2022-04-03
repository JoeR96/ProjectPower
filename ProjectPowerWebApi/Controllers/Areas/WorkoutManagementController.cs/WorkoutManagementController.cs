using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using ProjectPower.Areas.A2S_Program.Factories;
using ProjectPower.Areas.A2S_Program.Models.A2SWorkoutModels;
using ProjectPower.Areas.WorkoutCreation.Models.BaseWorkoutInformationService;
using ProjectPower.Areas.WorkoutCreation.Services;
using System;

namespace ProjectPowerWebApi.Controllers.Areas.WorkoutManagementController.cs
{
    [ApiController]
    [Route("Workout")]
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
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
        [HttpGet("DailyWorkout/{username}")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public ActionResult<ProjectPowerData.Folder.Models.Exercise> DailyWorkout(string username)
        {
            try
            {
                var response = JsonConvert.SerializeObject(_service.GetDailyWorkout(username));

                if (response != null)
                {
                    return Ok(response);
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
        [HttpPut("DailyWorkout/UpdateWorkOutResult")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult ExerciseResult(UpdateBasicWorkoutInformationModel model)
        {
            try
            {
                _service.UpdateExerciseResult(model);
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
        [HttpPut("UpdateDayAndWeek/{username}")]
        public ActionResult UpdateDayAndWeek(string username)
        {
            try
            {
                _service.UpdateDayAndWeek(username);
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
        [HttpGet("DummyData/A2SHypertrophy")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult CreateA2SDummyData()
        {
            try
            {
                var x = new A2SHypertrophyFactory();
                x.CreateDummyData();
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
