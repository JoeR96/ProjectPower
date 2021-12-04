using System;
using ProjectPower.Areas.A2S_Program.Models.A2SWorkoutModels;
using ProjectPower.Areas.WorkoutCreation.Models;

namespace ProjectPower.Areas.WorkoutCreation.Services
{
    public interface IWorkoutManagementService
    {
        ShowCreatedWorkoutModel CreateWorkout(CreateWorkoutMasterTemplateModel model);

    }
}
