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

        [HttpPost("CreateWorkout")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public ActionResult UpdateExerciseDayAndOrder(CreateWorkoutMasterTemplateModel model)
        {
            //call the service and create the workout using the masterial template model

            _service.CreateWorkout(model);
            return null;
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

        [HttpPost("Create")]
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

        [HttpPost("CreateA2SWorkout")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public ActionResult<ShowA2SWorkoutModel> Create(CreateA2SWorkoutMasterModel model)
        {
            try
            {
                foreach(var day in model.ExerciseDaysAndOrders)
                {
                    foreach(var exercise in day.hyperTrophyExercises)
                    _service.SaveCreateModel(exercise);

                }
                return NoContent();
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }
    }
}
