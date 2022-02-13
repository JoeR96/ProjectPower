using ProjectPower.Areas.A2S_Program.Factories;
using ProjectPower.Areas.A2S_Program.Helpers;
using ProjectPower.Areas.A2S_Program.Models.A2SWorkoutModels;
using ProjectPower.Areas.WorkoutCreation.Models.BaseWorkoutInformationService;
using ProjectPower.FactoryPattern;
using ProjectPowerData;
using ProjectPowerData.Folder.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectPower.Areas.WorkoutCreation.Services
{
    public class WorkoutManagementService : IWorkoutManagementService
    {
        DataContext _dc;
        Dictionary<string, ExerciseFactory> exerciseFactories = null;
        public WorkoutManagementService()
        {
            A2SHypertrophyFactory a2SHypertrophyFactory = new A2SHypertrophyFactory();
            A2SRepsThenSetsFactory a2SRepsThenSetsFactory = new A2SRepsThenSetsFactory();

            _dc = new DataContext();
            exerciseFactories = new Dictionary<string, ExerciseFactory>
            {
                { "A2SHypertrophy", a2SHypertrophyFactory },
                { "A2SRepsThenSets", a2SRepsThenSetsFactory }
            };
        }

        public void CreateWorkout(CreateWorkoutMasterTemplateModel model)
        {
            model.ExerciseDaysAndOrders.ForEach(e => exerciseFactories[e.Template].CreateExercise(e));
        }
  
        public List<BasicWorkoutInformation> GetDailyWorkout(string username)
        {
            var ua = _dc.UserAccounts.Where(e => e.UserName == username).FirstOrDefault();
            var _ = _dc.BasicWorkoutInformation.Where(e => e.UserName == username && e.ExerciseDay == ua.CurrentDay && e.Week == ua.CurrentWeek).ToList();
            _.ForEach(e => ValidateWorkout(e));
            return _;
        }

        private void ValidateWorkout(BasicWorkoutInformation e)
        {
            if(e.Template == "A2SHypertrophy")
            {
                A2SHelper.WorkingWeight((A2SHyperTrophy)e);
                _dc.SaveChanges();
            }
        }
        public void UpdateExerciseResult(UpdateBasicWorkoutInformationModel model)
        {
            var _ =_dc.BasicWorkoutInformation.Where(e => e.ExerciseMasterId == model.Id && e.Week == model.Week).FirstOrDefault();
            exerciseFactories[_.Template].UpdateExercise(model, _);
        }
        public void GetDayAndWeek(string username)
        {
            var user = _dc.UserAccounts.Where(u => u.UserName == username).FirstOrDefault();
        }
        public void UpdateDayAndWeek(string username)
        {
            var user = _dc.UserAccounts.Where(u => u.UserName == username).FirstOrDefault();
            if(user.CurrentDay < user.WorkoutDaysInWeek)
            {
                user.CurrentDay++;
            }
            else if(user.CurrentWeek < user.WorkoutWeeks)
            {
                user.CurrentWeek++;
                user.CurrentDay = 1;
            }
            else
            {
                //Program completed
            }
            _dc.SaveChanges();

        }
    }
}
