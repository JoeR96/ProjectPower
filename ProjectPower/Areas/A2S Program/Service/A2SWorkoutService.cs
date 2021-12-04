using ProjectPower.Areas.A2S_Program.Helpers;
using ProjectPower.Areas.A2S_Program.Models.A2SWorkoutModels;
using ProjectPower.Areas.A2S_Program.Service.Interfaces;
using ProjectPower.Areas.UserAccounts.Services.Interfaces;
using ProjectPowerData;
using ProjectPowerData.Folder.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectPower.Areas.A2S_Program.Service
{
    public class A2SWorkoutService : IA2SWorkoutService
    {
        private readonly DataContext _dc;

        private A2STemplateValues _a2sHelper = new A2STemplateValues();
        public A2SWorkoutService(DataContext context)
        {
            _dc = context;
        }

        List<A2SDailyWorkoutModel> IA2SWorkoutService.GetDailyWorkout(GetA2SWeeklyWorkout workout)
        {
            var exercises = _dc.A2SWorkoutExercises
               .Where(w => w.Week == workout.Week &&
                   w.LiftDay == workout.Day &&
                       w.Username == workout.Username)
               .Select(e => new A2SDailyWorkoutModel(e))
                .ToList();

            if (exercises == null)
            {
                return null;
            }
            else
            {
                return exercises;
            }
        }
 
        public void SaveAmrapResult(UpdateA2SAmrapResultModel model,long id)
        {
            var dbEntity = _dc.A2SWorkoutExercises.FirstOrDefault(m => m.Id == id);
            dbEntity.AmrapRepResult = model.AmrapRepResult;

            _dc.SaveChanges();
        }

        public void Delete(long id)
        {
            var dbEntity = _dc.A2SWorkoutExercises.Find(id);
            _dc.Remove(dbEntity);
            _dc.SaveChanges();
        }
    }
}
