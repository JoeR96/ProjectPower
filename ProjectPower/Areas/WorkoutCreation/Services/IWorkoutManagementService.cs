using ProjectPower.Areas.A2S_Program.Models.A2SWorkoutModels;
using ProjectPower.Areas.WorkoutCreation.Models.BaseWorkoutInformationService;
using ProjectPowerData.Folder.Models;
using System.Collections.Generic;

namespace ProjectPower.Areas.WorkoutCreation.Services
{
    public interface IWorkoutManagementService
    {
        public void CreateWorkout(CreateWorkoutMasterTemplateModel model);
        public List<BasicWorkoutInformation> GetDailyWorkout(string username, int week, int day);
        public void UpdateExerciseResult(UpdateBasicWorkoutInformationModel model);
    }
}
