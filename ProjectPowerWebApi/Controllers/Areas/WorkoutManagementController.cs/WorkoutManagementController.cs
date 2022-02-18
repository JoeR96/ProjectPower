using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using ProjectPower.Areas.A2S_Program.Models.A2SWorkoutModels;
using ProjectPower.Areas.WorkoutCreation.Models;
using ProjectPower.Areas.WorkoutCreation.Models.BaseWorkoutInformationService;
using ProjectPower.Areas.WorkoutCreation.Services;
using ProjectPowerData.Folder.Models;
using System;

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
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpGet("DailyWorkout/{username}")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public ActionResult<BasicWorkoutInformation> DailyWorkout(string username)
        {
            try
            {
                var response = JsonConvert.SerializeObject(_service.GetDailyWorkout(username));

                if (response != null)
                {
                    return CreatedAtAction(nameof(WorkoutManagementController.DailyWorkout), response);
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
    }
}
