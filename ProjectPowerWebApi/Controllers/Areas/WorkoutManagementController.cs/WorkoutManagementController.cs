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
    public class WorkoutManagementController
    {
        private readonly ILogger<WorkoutManagementController> _logger;
        private readonly IWorkoutManagementService _service;

        public WorkoutManagementController()
        {
        }

        [HttpPost("CreateWorkout")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public ActionResult<ShowCreatedWorkoutModel> CreateWorkout(CreateWorkoutMasterTemplateModel model)
        {
            try
            {
                var response = _service.CreateWorkout(model);
                return response;
            }
            catch(Exception ex)
            {
                return Problem(ex.Message);
            }
        }
    }
}
