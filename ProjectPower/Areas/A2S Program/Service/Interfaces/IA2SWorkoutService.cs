using ProjectPower.Areas.A2S_Program.Models.A2SWorkoutModels;
using ProjectPower.Areas.WorkoutCreation.Models;
using ProjectPowerData.Folder.Models;
using System.Collections.Generic;



namespace ProjectPower.Areas.A2S_Program.Service.Interfaces
{
    public interface IA2SWorkoutService
    {
        int GetCount(A2SWorkoutSearchModel search);

        List<BaseExercise> GetDailyWorkout(GetA2SWeeklyWorkout workout);

        ShowA2SWorkoutModel GetShowModelByName(string name);

        UpdateA2SAmrapResultModel GetUpdateModel(long id);

        void SaveAmrapResult(UpdateA2SAmrapResultModel model,long id);
        void UpdateDayAndOrder(string uniqueId, int day, int order);

        CreateA2SWorkoutModel GetCreateModel();

        ShowA2SWorkoutModel SaveCreateModel(CreateA2SWorkoutModel model);

        void Delete(long id);
        void CreateWorkout(CreateWorkoutMasterTemplateModel model);
    }
}
