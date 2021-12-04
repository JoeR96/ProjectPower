using System;
using ProjectPower.Areas.A2S_Program.Models.A2SWorkoutModels;
using ProjectPower.Areas.WorkoutCreation.Models;

namespace ProjectPower.Areas.WorkoutCreation.Services
{
    public class WorkoutManagementService : IWorkoutManagementService
    {
        public WorkoutManagementService()
        {
        }

        public ShowCreatedWorkoutModel CreateWorkout(CreateWorkoutMasterTemplateModel model)
        {
            foreach(var exercise in model.ExerciseDaysAndOrders)
            {
                //get the template and send it on the relevant path
                exercise.Template
            }
        }
    }
}
