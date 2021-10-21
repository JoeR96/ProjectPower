using ProjectPower.Areas.A2S_Program.Models.A2SWorkoutModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPower.Areas.A2S_Program.Service.Interfaces
{
    public interface IA2SWorkoutService
    {
        IEnumerable<ShowA2SWorkoutModel> GetIndexModel(A2SWorkoutSearchModel search);
        int GetCount(A2SWorkoutSearchModel search);

        List<A2SDailyWorkoutModel> GetDailyWorkout(GetA2SWeeklyWorkout workout);

        ShowA2SWorkoutModel GetShowModelByName(string name);

        UpdateA2SAmrapResultModel GetUpdateModel(long id);

        void SaveAmrapResult(UpdateA2SAmrapResultModel model,long id);

        CreateA2SWorkoutModel GetCreateModel();

        ShowA2SWorkoutModel SaveCreateModel(CreateA2SWorkoutModel model);

        void Delete(long id);
    }
}
