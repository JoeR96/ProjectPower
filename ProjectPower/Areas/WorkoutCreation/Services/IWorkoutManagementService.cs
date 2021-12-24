using System;
using System.Linq;
using ProjectPower.Areas.A2S_Program.Models.A2SWorkoutModels;
using ProjectPower.Areas.WorkoutCreation.Models;
using ProjectPowerData.Folder.Models;

namespace ProjectPower.Areas.WorkoutCreation.Services
{
    public interface IWorkoutManagementService
    {
        public void CreateWorkout(CreateWorkoutMasterTemplateModel model);
        public IQueryable<BasicWorkoutInformation> GetDailyWorkout(string username, int week, int day);
    }
}
