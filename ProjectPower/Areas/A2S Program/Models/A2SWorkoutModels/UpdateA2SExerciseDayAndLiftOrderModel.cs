
using ProjectPower.Areas.WorkoutCreation.Models;

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
