using ProjectPower.Areas.A2S_Program.Models.A2SWorkoutModels;
using ProjectPower.Areas.WorkoutCreation.Models.BaseWorkoutInformationService;
using ProjectPowerData.Folder.Models;

namespace ProjectPower.Areas.WorkoutCreation.Services
{
    public interface IWorkoutManagementService
    {
        public void CreateWorkout(CreateWorkoutMasterTemplateModel model);
        public List<Exercise> GetDailyWorkout(string username);
        public void UpdateExerciseResult(UpdateWeeklyExerciseModel model);
        public void UpdateDayAndWeek(string username);
        public void GetDayAndWeek(string username);
    }
}
