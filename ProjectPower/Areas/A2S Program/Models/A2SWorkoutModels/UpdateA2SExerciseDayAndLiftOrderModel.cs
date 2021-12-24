
using System.Collections.Generic;
using ProjectPower.Areas.ExerciseCreation.Models;

namespace ProjectPower.Areas.A2S_Program.Models.A2SWorkoutModels
{
    public class CreateWorkoutMasterTemplateModel
    {
        public List<CreateExerciseModel> ExerciseDaysAndOrders { get; set; }
        public CreateWorkoutMasterTemplateModel()
        {

        }
    }
}
